namespace drg_group.changzhou_2022{
    public class RD1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"Z51.800x092","Z51.800x097","Z51.800x921"};
            String[] adrg_zd1={};
            String[] adrg_ss={"32.2004","32.2400x001","32.2500x001","32.2900x005","39.7100x004","39.7900x017","39.7900x019","39.7900x020","39.7900x021","39.7900x025","39.7903","39.7904","39.7906","41.4200x003","41.9100x001","41.9200","41.9201","41.9202","41.9203","44.4400x005","44.4403","50.2301","50.2302","50.2303","50.2401","50.2402","50.2403","50.2404","50.2501","50.2502","50.2503","50.2902","52.2202","54.4x00x039","54.4x00x048","68.2500x001","99.2501","99.2502"};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0]) && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合RD1入组条件，匹配规则：主诊断匹配、主手术匹配");
                    
                if (MDCR_DRG.RD19_group(record))
                {
                    return "RD19";
                }

                return "RD1";
            }else{
                return "";
            }
        }
    }
}