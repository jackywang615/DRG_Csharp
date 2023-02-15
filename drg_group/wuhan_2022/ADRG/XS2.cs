namespace drg_group.wuhan_2022{
    public class XS2
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"R74.804","R79.804","R89.000","R89.100","R89.200","R89.300","R89.400","R89.500","R89.600","R89.700","R89.800","R93.202","R93.301","Z00.500x001","Z00.600","Z01.001","Z01.002","Z01.101","Z01.102","Z01.200","Z01.300","Z01.600x001","Z01.700","Z01.800x001","Z01.800x004","Z02.000","Z02.100","Z02.300","Z02.400","Z02.500","Z02.600","Z09.000x001","Z09.300","Z09.400","Z09.700","Z09.801","Z09.802","Z09.803","Z09.804","Z09.900x001","Z29.101","Z29.200x001","Z29.201","Z29.800","Z29.900","Z51.600","Z51.901"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合XS2入组条件，匹配规则：主诊断匹配");
                    
                if (MDCX_DRG.XS29_group(record))
                {
                    return "XS29";
                }

                return "XS2";
            }else{
                return "";
            }
        }
    }
}