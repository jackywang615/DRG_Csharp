namespace drg_group.linfen_2022{
    public class OR1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"Z37.000","Z37.000x001","Z37.001","Z37.002","Z37.100","Z37.100x002","Z37.200","Z37.200x003","Z37.201","Z37.202","Z37.203","Z37.204","Z37.300","Z37.300x001","Z37.301","Z37.302","Z37.303","Z37.400","Z37.400x001","Z37.500","Z37.500x001","Z37.501","Z37.502","Z37.600","Z37.600x001","Z37.700","Z37.700x001","Z37.900","Z37.900x003"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合OR1入组条件，匹配规则：主诊断匹配");
                    
                if (MDCO_DRG.OR19_group(record))
                {
                    return "OR19";
                }

                return "OR1";
            }else{
                return "";
            }
        }
    }
}