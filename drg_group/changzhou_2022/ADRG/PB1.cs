namespace drg_group.changzhou_2022{
    public class PB1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && record.ageDay<=28){
                Base.groupMessages.putMessage(record.Index,"符合PB1入组条件，匹配规则：新生儿");
                    
                if (MDCP_DRG.PB19_group(record))
                {
                    return "PB19";
                }

                return "PB1";
            }else{
                return "";
            }
        }
    }
}