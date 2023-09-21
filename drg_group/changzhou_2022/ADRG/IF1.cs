namespace drg_group.changzhou_2022{
    public class IF1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"77.0200","77.0301","77.0302","77.1101","77.1102","77.1200x001","77.1200x002","77.1300x001","77.1301","77.1302","77.2200x001","77.2200x002","77.2200x003","77.2300x001","77.2300x002","77.2301","77.2302","77.3101","77.3102","77.3200","77.3301","77.3302","77.6201","77.6301","77.6302","77.7200","77.7301","77.7302","77.8200","77.8200x002","77.8300x002","77.8300x005","77.8300x006","77.8301","77.8302","77.8303","77.9200","77.9301","77.9302","78.0200x001","78.0200x002","78.0300x004","78.0300x005","78.0301","78.0302","78.1201","78.1301","78.1302","78.2200","78.2301","78.2302","78.2903","78.3200x001","78.3301","78.3302","78.4102","78.4103","78.4201","78.4301","78.4302","78.5101","78.5200x003","78.5200x004","78.5200x005","78.5200x006","78.5201","78.5300x002","78.5300x003","78.5300x004","78.5300x005","78.5300x006","78.5300x007","78.5300x008","78.5300x009","78.5301","78.5302","78.7200","78.7301","78.7302","78.9200","78.9301","78.9302","79.0100x001","79.0201","79.0202","79.0901","79.1100x002","79.1100x003","79.1100x004","79.1100x005","79.1200x003","79.1200x004","79.1200x005","79.1200x006","79.1200x007","79.1200x008","79.1200x009","79.1200x010","79.1201","79.1202","79.2101","79.2201","79.2202","79.3100x004","79.3100x005","79.3100x006","79.3100x007","79.3100x008","79.3100x009","79.3101","79.3200x001","79.3200x002","79.3200x009","79.3200x010","79.3200x011","79.3200x012","79.3200x013","79.3200x014","79.3201","79.3202","79.3902","79.4101","79.4201","79.4202","79.5100","79.5201","79.5202","79.6100","79.6201","79.6202","79.6901","79.9100","79.9200","81.8400x002","81.8500x001","84.0500","84.0701","84.2301","84.2401","84.4101","84.4102","84.4201","84.4202","84.4300"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合IF1入组条件，匹配规则：主手术匹配");
                    
                if (MDCI_DRG.IF19_group(record))
                {
                    return "IF19";
                }

                return "IF1";
            }else{
                return "";
            }
        }
    }
}