namespace drg_group.chs_drg_11{
    public class JB3
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"40.1900x002","40.2200","85.0x00x002","85.0x00x003","85.0x01","85.0x02","85.2000x001","85.2000x002","85.2100x003","85.2100x019","85.2100x020","85.2100x021","85.2100x022","85.2101","85.2400x004","85.2400x005","85.2401","85.2402","85.2500","85.9900"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合JB3入组条件，匹配规则：主手术匹配");
                    
                if (MDCJ_DRG.JB39_group(record))
                {
                    return "JB39";
                }

                return "JB3";
            }else{
                return "";
            }
        }
    }
}