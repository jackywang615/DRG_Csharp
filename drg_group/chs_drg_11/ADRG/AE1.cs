namespace drg_group.chs_drg_11{
    public class AE1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"55.6100","55.6901"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合AE1入组条件，匹配规则：主手术匹配");
                    
                if (MDCA_DRG.AE19_group(record))
                {
                    return "AE19";
                }

                return "AE1";
            }else{
                return "";
            }
        }
    }
}