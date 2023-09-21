namespace drg_group.changzhou_2022{
    public class GD1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"C18.100","K35.200","K35.201","K35.300","K35.301"};
            String[] adrg_zd1={};
            String[] adrg_ss={"47.0100","47.0901","47.0902","47.0903","47.1100","47.2x00","47.2x01","47.9100","47.9200","47.9901"};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0]) && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合GD1入组条件，匹配规则：主诊断匹配、主手术匹配");
                    
                if (MDCG_DRG.GD19_group(record))
                {
                    return "GD19";
                }

                return "GD1";
            }else{
                return "";
            }
        }
    }
}