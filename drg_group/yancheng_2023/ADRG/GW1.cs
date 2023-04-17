namespace drg_group.yancheng_2023{
    public class GW1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"A04.000x002","A04.100x001","A04.200x001","A04.300x001","A04.400x004","A04.401","A04.500","A04.600","A04.600x001","A04.700","A04.700x002","A04.701","A04.702","A04.800x001","A04.800x003","A04.800x006","A04.800x007","A04.800x010","A04.801","A04.802","A04.803","A04.900","A04.901","A04.902","A05.000","A05.000x001","A05.100","A05.200","A05.200x002","A05.202","A05.300","A05.300x001","A05.400","A05.400x001","A05.800","A05.900","A07.000","A07.100","A07.200","A07.300","A07.300x002","A07.800x002","A07.801","A07.900x001","A08.000","A08.100x001","A08.101","A08.200","A08.300","A08.301","A08.400","A08.400x003","A08.401","A08.402","A08.500","A09.000x001","A09.000x003","A09.000x006","A09.001","A09.002","A09.004","A09.005","A09.006","A09.007","A09.900x003","A09.900x004","A09.900x006","A09.900x007","A09.901","A09.901","A09.902","A09.902","A09.903","A09.904","A18.800x014+K23.0*","A18.807+K23.0*","A49.809","A60.102+K93.8*","B37.804","B37.805","B37.806","B49.x00x002","B49.x12","B49.x16","B49.x17","K20.x00","K20.x00x001","K20.x00x003","K20.x00x006","K20.x01","K20.x02","K20.x03","K21.001","K29.000","K29.001","K29.100x001","K29.101","K29.200","K29.300","K29.400","K29.500","K29.501","K29.600","K29.600x006","K29.600x007","K29.601","K29.602","K29.603","K29.604","K29.605","K29.606","K29.608","K29.700","K29.700x002","K29.701","K29.800","K29.801","K29.802","K29.900","K51.500","K52.902","K52.903","K52.904","K52.907","K52.908","K52.909","K52.910","K52.911","K52.912","K52.914","K52.917","K52.918","K57.000","K57.001","K57.002","K57.003","K57.100x005","K57.102","K57.103","K57.104","K57.105","K57.106","K57.107","K57.108","K57.200x001","K57.201","K57.202","K57.300x006","K57.301","K57.302","K57.303","K57.304","K57.305","K58.100","K58.200","K58.300","K58.800","K58.800","K58.801"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合GW1入组条件，匹配规则：主诊断匹配");
                    
                if (MDCG_DRG.GW19_group(record))
                {
                    return "GW19";
                }

                return "GW1";
            }else{
                return "";
            }
        }
    }
}