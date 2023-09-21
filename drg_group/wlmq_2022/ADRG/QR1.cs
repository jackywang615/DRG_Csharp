namespace drg_group.wlmq_2022{
    public class QR1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"C26.100","C78.805","C79.826","D13.901","D17.700x031","D18.000x044","D18.100x002","D18.100x003","D18.100x006","D18.100x017","D18.100x018","D18.100x019","D18.100x023","D18.100x024","D18.103","D18.104","D18.107","D21.900x015","D36.000","D37.700x005","D37.703","D37.704","D47.700x008","D47.700x009","D47.700x010","D47.700x011","D70.x00","D70.x00x001","D70.x00x003","D70.x00x004","D70.x00x005","D70.x00x008","D70.x00x010","D70.x00x011","D70.x01","D70.x02","D70.x03","D70.x04","D70.x05","D70.x06","D70.x07","D71.x00","D71.x00x002","D71.x00x003","D71.x00x004","D71.x00x005","D71.x01","D72.000","D72.001","D72.100","D72.101","D72.102","D72.104","D72.105","D72.800","D72.800x003","D72.801","D72.802","D72.803","D72.804","D72.805","D72.806","D72.807","D72.808","D72.809","D72.900","D73.000","D73.001","D73.002","D73.100","D73.200","D73.300","D73.400","D73.500","D73.501","D73.502","D73.503","D73.504","D73.505","D73.800x002","D73.800x007","D73.800x010","D73.800x011","D73.801","D73.802","D73.803","D73.804","D73.805","D73.807","D73.808","D73.900","D73.901","D75.000","D75.000x002","D75.100","D75.101","D75.102","D75.103","D75.104","D75.105","D75.106","D75.107","D75.108","D75.109","D75.110","D75.111","D75.800","D75.800x003","D75.801","D75.802","D75.803","D75.804","D75.805","D75.806","D75.807","D75.809","D75.901","D75.902","D76.100x003","D76.100x004","D76.100x005","D76.101","D76.102","D76.200","D76.300","D76.301","D76.302","D76.303","D76.304","D80.000","D80.001","D80.002","D80.100","D80.100x003","D80.101","D80.102","D80.200x001","D80.300","D80.400","D80.500","D80.601","D80.700","D80.800","D80.800x001","D80.900","D80.900x002","D80.901","D81.000","D81.000x002","D81.100","D81.200","D81.400","D81.600","D81.601","D81.700","D81.800","D81.801","D81.802","D81.803","D81.900","D81.900x001","D81.901","D82.000","D82.100","D82.200","D82.300","D82.300x002","D82.301","D82.400","D82.800","D82.800x001","D82.900","D83.000","D83.100","D83.200","D83.800","D83.900","D84.000","D84.100","D84.100x002","D84.100x005","D84.101","D84.102","D84.103","D84.800","D84.800x001","D84.900","D84.900x002","D84.900x003","D86.100","D86.101","D89.000","D89.000x003","D89.000x004","D89.001","D89.002","D89.100","D89.100x001","D89.100x002","D89.100x003","D89.100x004","D89.100x005","D89.100x006","D89.100x007","D89.200","D89.300","D89.301","D89.800","D89.800x002","D89.800x003","D89.900","E85.400x004","I86.810","I88.100","I88.108","I88.800x001","I88.900x003","I88.900x005","I88.900x006","I88.901","I89.010","I89.800x011","I89.802","I89.806","L03.901","L04.100","L04.200","L04.201","L04.202","L04.300","L04.301","L04.800","L04.900","L04.900x002","L04.900x005","L04.900x007","L04.901","L04.902","M32.111+D77*","Q27.807","Q85.907","Q89.004","Q89.004","Q89.200x601","Q89.208","R16.100x001","R59.000x009","R59.000x010","R59.000x012","R59.000x013","R59.002","R59.003","R59.004","R59.005","R59.006","R59.007","R59.008","R59.010","R59.011","R59.012","R59.013","R59.014","R59.100","R59.100x002","R93.300x002","R94.800x001","S36.000","S36.000x021","S36.000x031","S36.000x081","S36.001","S36.002","S36.011","T86.000","T86.000x003","T86.000x004","T86.001"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合QR1入组条件，匹配规则：主诊断匹配");
                    
                if (MDCQ_DRG.QR11_group(record))
                {
                    return "QR11";
                }
    
                if (MDCQ_DRG.QR13_group(record))
                {
                    return "QR13";
                }
    
                if (MDCQ_DRG.QR15_group(record))
                {
                    return "QR15";
                }

                return "QR1";
            }else{
                return "";
            }
        }
    }
}