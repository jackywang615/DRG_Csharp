namespace drg_group.chs_drg_11{
    public class HT2
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"B25.200+K87.1*","B26.300+K87.1*","K85.000","K85.001","K85.100","K85.101","K85.200","K85.201","K85.300","K85.301","K85.803","K85.807","K85.808","K85.809","K85.900","K85.900x002","K85.900x003","K85.901"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合HT2入组条件，匹配规则：主诊断匹配");
                    
                if (MDCH_DRG.HT21_group(record))
                {
                    return "HT21";
                }
    
                if (MDCH_DRG.HT23_group(record))
                {
                    return "HT23";
                }
    
                if (MDCH_DRG.HT25_group(record))
                {
                    return "HT25";
                }

                return "HT2";
            }else{
                return "";
            }
        }
    }
}