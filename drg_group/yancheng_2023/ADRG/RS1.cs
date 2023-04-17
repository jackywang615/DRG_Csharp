namespace drg_group.yancheng_2023{
    public class RS1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"C81.000","C81.100","C81.200","C81.300","C81.400","C81.700","C81.701","C81.702","C81.703","C81.900","C82.000","C82.100","C82.200","C82.300","C82.400","C82.500","C82.600","C82.700","C82.701","C82.702","C82.703","C82.704","C82.900","C82.901","C82.903","C83.000","C83.001","C83.002","C83.003","C83.004","C83.100","C83.101","C83.102","C83.300","C83.300x006","C83.300x007","C83.300x008","C83.300x009","C83.301","C83.302","C83.303","C83.304","C83.305","C83.306","C83.307","C83.500","C83.501","C83.502","C83.503","C83.504","C83.505","C83.700","C83.702","C83.703","C83.800","C83.800x006","C83.800x008","C83.800x009","C83.801","C83.802","C83.803","C83.900","C84.000","C84.000x002","C84.000x003","C84.100","C84.400","C84.400x001","C84.401","C84.402","C84.403","C84.404","C84.405","C84.406","C84.407","C84.500","C84.500x004","C84.500x012","C84.500x016","C84.502","C84.600","C84.601","C84.700","C84.800","C84.900","C84.901","C85.100","C85.100x010","C85.100x017","C85.100x021","C85.700","C85.700x004","C85.700x016","C85.701","C85.704","C85.705","C85.707","C85.709","C85.715","C85.900","C85.900x001","C85.900x002","C85.900x003","C85.900x004","C85.900x005","C85.900x006","C85.900x009","C85.900x010","C85.900x011","C85.900x012","C85.900x014","C85.900x015","C85.900x016","C85.900x017","C85.900x019","C85.900x020","C85.900x022","C85.900x023","C85.900x024","C85.900x025","C85.900x026","C85.900x027","C85.900x028","C85.900x029","C85.900x030","C85.900x031","C85.900x034","C85.900x036","C85.900x037","C85.900x038","C85.900x039","C85.900x040","C85.900x041","C85.900x042","C85.900x043","C85.901","C86.000","C86.100","C86.200","C86.300","C86.400","C86.500","C86.600","C86.601","C86.602","C86.603","C88.000","C88.000x002","C88.000x011","C88.000x012","C88.200","C88.200x011","C88.200x012","C88.201","C88.202","C88.203","C88.300","C88.301","C88.302","C88.400","C88.401","C88.403","C88.700","C88.700x002","C88.700x003","C88.700x012","C88.700x013","C88.701","C88.900","C88.900x001","C91.000x006","C91.100","C91.100x011","C91.101","C91.102","C91.300","C91.400","C91.400x004","C91.400x013","C91.401","C91.500","C91.500x011","C91.600","C91.700","C91.701","C91.704","C91.800","C91.900","C91.901","C92.100","C92.100x001","C92.100x004","C92.100x011","C92.100x014","C92.100x016","C92.100x018","C92.100x019","C92.101","C92.102","C92.103","C92.200","C92.200x001","C92.200x011","C92.201","C92.300","C92.300x001","C92.300x003","C92.300x011","C92.300x013","C92.700","C92.700x006","C92.700x012","C92.700x013","C92.701","C92.703","C92.706","C92.900","C92.900x001","C92.900x011","C92.901","C93.100","C93.100x011","C93.100x013","C93.101","C93.102","C93.103","C93.104","C93.300","C93.300x001","C93.700","C93.701","C93.900","C93.901","C94.300","C94.300x011","C94.600","C94.700x004","C94.700x014","C94.703","C95.100","C95.100x011","C95.700x001","C95.700x002","C95.700x003","C95.700x011","C95.900","C95.900x003+M36.1*","C95.900x005","C95.900x012","C95.900x013+M36.1*","C95.900x015","C95.901","C96.000","C96.002","C96.004","C96.200","C96.200x005","C96.200x013","C96.201","C96.202","C96.400","C96.400x001","C96.400x002","C96.400x003","C96.400x004","C96.401","C96.402","C96.500","C96.501","C96.502","C96.600","C96.601","C96.602","C96.603","C96.604","C96.704","C96.705","C96.800","C96.801","C96.900","D45.x00","D46.001","D46.100","D46.100x002","D46.100x012","D46.200","D46.201x001","D46.203","D46.400","D46.500","D46.600","D46.600","D46.700x001","D46.700x002","D46.700x003","D46.700x006","D46.700x007","D46.700x008","D46.900","D46.900x002","D46.900x004","D46.900x006","D46.901","D47.000","D47.001","D47.002","D47.003","D47.004","D47.100","D47.100","D47.100x004","D47.100x007","D47.100x008","D47.100x009","D47.100x017","D47.100x018","D47.100x019","D47.101","D47.200","D47.200x003","D47.200x004+G63.1*","D47.200x005+G63.1*","D47.300","D47.400","D47.401","D47.402","D47.403","D47.404","D47.500","D47.700","D47.700x005","D47.700x006","D47.700x007","D47.700x007","D47.701","D47.702","D47.703","D47.900","D47.900x001","D47.900x002"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合RS1入组条件，匹配规则：主诊断匹配");
                    
                if (MDCR_DRG.RS11_group(record))
                {
                    return "RS11";
                }
    
                if (MDCR_DRG.RS13_group(record))
                {
                    return "RS13";
                }
    
                if (MDCR_DRG.RS15_group(record))
                {
                    return "RS15";
                }

                return "RS1";
            }else{
                return "";
            }
        }
    }
}