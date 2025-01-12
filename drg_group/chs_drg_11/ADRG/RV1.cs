namespace drg_group.chs_drg_11{
    public class RV1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"Z51.000x003","Z51.000x008","Z51.000x012","Z51.001","Z51.002","Z51.003","Z51.806","Z51.811"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合RV1入组条件，匹配规则：主诊断匹配");
                    
                if (MDCR_DRG.RV11_group(record))
                {
                    return "RV11";
                }
    
                if (MDCR_DRG.RV15_group(record))
                {
                    return "RV15";
                }

                return "RV1";
            }else{
                return "";
            }
        }
    }
}