namespace drg_group.chs_drg_11{
    public class AC1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"52.8000","52.8200","52.8300"};
            String[] adrg_ss1={"55.6100","55.6901"};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && Base.intersect(record.ssList,adrg_ss) && Base.intersect(record.ssList,adrg_ss1)){
                Base.groupMessages.putMessage(record.Index,"符合AC1入组条件，匹配规则：双手术匹配");
                    
                if (MDCA_DRG.AC19_group(record))
                {
                    return "AC19";
                }

                return "AC1";
            }else{
                return "";
            }
        }
    }
}