namespace drg_group.chs_drg_11{
    public class OB1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"74.0x00","74.0x00x001","74.0x00x002","74.1x01","74.1x02","74.2x00","74.4x01","74.9900"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合OB1入组条件，匹配规则：主手术匹配");
                    
                if (MDCO_DRG.OB19_group(record))
                {
                    return "OB19";
                }

                return "OB1";
            }else{
                return "";
            }
        }
    }
}