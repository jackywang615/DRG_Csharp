namespace drg_group.chs_drg_11{
    public class RW2
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"Z51.000x013","Z51.100x004","Z51.500x003","Z51.800x953","Z51.800x983"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合RW2入组条件，匹配规则：主诊断匹配");
                    
                if (MDCR_DRG.RW21_group(record))
                {
                    return "RW21";
                }
    
                if (MDCR_DRG.RW23_group(record))
                {
                    return "RW23";
                }
    
                if (MDCR_DRG.RW25_group(record))
                {
                    return "RW25";
                }

                return "RW2";
            }else{
                return "";
            }
        }
    }
}