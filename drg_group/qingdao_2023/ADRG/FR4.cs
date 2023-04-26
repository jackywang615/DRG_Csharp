namespace drg_group.qingdao_2023{
    public class FR4
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"I20.808","I24.000x003","I24.000x004","I24.000x005","I24.000x009","I24.000x010","I24.001","I24.002","I24.003","I24.100x001","I24.800x001","I24.800x004","I24.800x007","I24.801","I24.900x001","I24.901","I25.000x001","I25.100x003","I25.102","I25.103","I25.400","I25.400x001","I25.400x005","I25.401","I25.402","I25.403","I25.600x001","I25.800x002","I25.800x003","I25.800x004","I25.800x005","I25.800x006","I25.800x009","I25.800x010","I25.800x011","I25.800x012","I25.802","I25.900","I25.901","I25.902","I51.600x002","I51.600x003","T82.201"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合FR4入组条件，匹配规则：主诊断匹配");
                    
                if (MDCF_DRG.FR49_group(record))
                {
                    return "FR49";
                }

                return "FR4";
            }else{
                return "";
            }
        }
    }
}