namespace drg_group.chs_drg_11{
    public class FR3
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"I20.000","I20.000x004","I20.000x005","I20.001","I20.002","I20.003","I20.004","I20.005","I20.006","I20.101","I20.102","I20.800x006","I20.800x007","I20.801","I20.802","I20.803","I20.806","I20.807","I20.808","I20.900"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合FR3入组条件，匹配规则：主诊断匹配");
                    
                if (MDCF_DRG.FR39_group(record))
                {
                    return "FR39";
                }

                return "FR3";
            }else{
                return "";
            }
        }
    }
}