namespace drg_group.chs_drg_11{
    public class OC1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"72.0x00","72.2100","72.2900x001","72.3100","72.3900x001","72.7100x001","73.5100","73.5900x001","73.5900x002","73.5900x003","73.6x00x002","73.6x01","73.6x02","73.8x00x002","73.8x00x003","73.8x00x005","73.8x00x006","73.8x01","73.8x02","73.9200","73.9300","73.9400","73.9900","75.4x00x001","75.4x00x002","75.4x00x003","75.6905","75.9100x001"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合OC1入组条件，匹配规则：主手术匹配");
                    
                if (MDCO_DRG.OC19_group(record))
                {
                    return "OC19";
                }

                return "OC1";
            }else{
                return "";
            }
        }
    }
}