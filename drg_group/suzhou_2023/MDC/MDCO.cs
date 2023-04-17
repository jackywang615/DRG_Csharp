namespace drg_group.suzhou_2023
{
    public class MDCO
    {
        public static String group(MedicalRecord record){
            String[] mdc_zd={"O91.101","O43.106","O36.305","O99.700x008","O65.900","O99.800x316","O60.200","O31.800x004","O99.408","O21.200","O90.500","O75.800x002","O35.800x006","O98.404","O04.001","O00.112","O32.301","O68.800","O26.400","O99.008","Z37.000","O99.302","O08.000","Z37.100x002","O99.314","O99.624","O35.200x003","O99.700x031","O44.000x002","O88.101","O29.000x003","O98.800x033","O30.800","O30.801","O99.107","O07.600","O33.700x005","O32.100x004","O99.811","O47.000","O86.801","O43.804","O74.200x002","O41.104","O99.800x111","O71.900","O80.100","Z35.200x006","O98.802","O43.200x002","O74.300","O75.101","O26.800x015","O03.501","O04.602","O70.200x001","O72.000","O21.100x005","O43.002","O71.401","O26.803","O36.301","O25.x01","O31.200","O34.700","O99.809","O21.800","O99.304","O26.608","O69.804","O91.202","O21.100x006","O07.000","O26.801","Z39.000x021","O71.402","O75.401","O99.308","O61.000x002","O70.100x004","O04.800x061","O99.500x021","O00.114","O26.701","O03.903","O35.900","O08.801","O82.800","O44.003","O08.000x007","O61.000x001","O99.700x021","O99.000x031","O28.800","Z64.000x001","O98.800x009","O65.201","O69.209","O66.201","O90.101","O98.001","O90.802","O04.300x031","O66.401","O08.400x005","O35.200x002","O99.407","O89.100x001","O62.400x005","O35.811","O71.501","O98.800x037","Z35.101","O99.006","O98.800x036","O75.402","O43.800","O35.800x010","O35.822","O99.218","O35.800x019","O99.600x011","O35.800x030","O98.400x031","O98.406","O68.101","O44.000x001","O35.800x011","O99.100x033","O08.200x003","O28.100","O91.201","O43.801","O99.800x032","O34.400x009","O34.000x011","O62.000","O99.800x217","O33.700x006","O71.202","O74.100","O86.800x001","O08.400x003","O35.010","O35.800x001","O24.301","O98.503","O36.203","O71.502","O03.503","O99.800x319","O98.801","O28.502","O33.101","O99.400x027","O34.800x015","O24.400","O91.200x008","O98.806","O71.601","O91.000","O99.800x115","O08.900","O36.601","O08.101","O99.217","O41.000x002","O33.501","O34.800x018","O03.200x001","O34.004","Z34.000x001","O69.200","O99.700x009","O90.400x002","Z37.204","O36.300x007","O99.800x131","O69.210","O12.200","O32.801","O99.800x023","O02.800","O98.400x021","O08.600x004","O44.100x002","O99.503","Z35.100","O02.000x001","O61.800","O34.000x006","O72.101","O03.600x001","O05.900","O35.200x004","O46.000x001","O99.800x215","O99.602","O74.500","O08.104","O23.500","O99.603","O29.000x001","Z36.202","Z36.400x001","O33.300x003","O99.700x011","O99.704","O08.400x004","O99.808","O89.300","O00.101","Z36.803","O35.800x005","O35.800x027","O35.006","O00.805","O08.200x001","O32.000x001","O20.800","O99.710","O41.103","O21.100","O33.400","O35.002","O66.300x004","O41.801","O99.400x031","O86.002","O68.201","O04.000x003","O04.600x001","O71.703","O86.802","O69.001","O91.200x007","O99.711","O35.800x020","O99.800x024","O34.301","O99.209","O96.100","O35.800x017","O35.803","O98.809","O89.000x004","O43.001","O34.400x014","O99.623","O98.300x014","O04.101","O34.800x006","O02.002","O26.804","Z35.200","O99.222","O86.400x001","O34.600x006","O29.000x004","O99.303","O12.100","O25.x00","O91.200x004","O33.900","O74.900x001","O99.501","O99.207","O24.200x001","O63.001","O04.500x002","O00.109","O04.500x001","O84.200","O34.200x002","O02.100","O08.601","O99.400x030","O98.200x031","O03.800x061","O08.000x005","O86.300x001","O34.002","O71.802","O29.500","O99.213","O99.415","O03.800x031","O99.300x022","O36.900","Z37.400x001","O23.200","O99.312","O69.205","O71.701","O23.504","O29.800","O08.105","O01.102","O23.500x009","O99.200x031","O99.621","O24.900","O02.800x001","O92.400","O31.201","O10.900x001","O00.111","Z38.500x001","O99.211","O99.208","O43.111","O99.700x006","O99.405","O99.400x022","O30.200","O92.200","O90.800x004","O34.800x005","O98.400x005","O00.001","O00.802","O34.102","O90.800x006","O21.100x003","O07.500","O41.900","O89.900","O71.600","O99.315","O23.001","O43.105","O97.900","O33.000x003","O99.300x016","O35.821","O23.502","O34.000x009","O99.412","O08.603","O06.500","O03.300x061","O00.902","O20.900","O04.200x001","O34.802","O88.300x002","O41.800x004","O47.100","O34.005","O64.200","O87.802","O99.100x032","O34.000x007","O81.100","O99.611","O90.400","O08.000x011","O04.300x081","O08.800x006","O99.600x031","O99.600x018","O72.300x003","O08.002","O62.406","O99.205","O03.601","O86.001","O99.800x014","O35.701","O10.001","Z35.201","Z37.301","O99.104","O35.813","O08.401","O26.606","O98.000","O98.000x021","O71.500x004","O72.003","O21.001","O98.900","O00.804","O00.105","O22.000","O40.x00","O23.500x007","O10.401","O67.800","O08.203","O26.800x011","O65.500x002","O83.400","O32.102","O34.800x011","Z37.300x001","O07.000x001","O73.101","O85.x01","O69.202","O12.000","O00.102","O66.101","O99.414","O99.800x022","O34.800x004","O08.805","O08.700","O35.820","O98.800x032","O36.502","O99.800x416","O36.303","O26.200","O34.201","O36.300x009","O33.201","O36.503","O69.401","O35.800x002","Z38.100x001","O35.817","O28.000","O99.600x021","O05.100","O45.000","O99.224","O70.300x001","O98.811","O90.900","O86.101","O98.800x002","Z37.302","O71.301","O00.901","O35.800x026","O26.601","O99.506","O34.602","O08.803","O71.200","O62.100","O92.700","O08.103","O71.400","O00.107","O98.400x011","O65.101","O21.900","O99.200x014","O99.604","O00.808","O10.301","O98.100","O88.200","O42.100x011","O99.814","O99.400x033","O99.400x034","O21.000","O62.401","O62.400x006","Z37.500x001","Z36.201","O99.428","O99.800x413","O05.700","O43.800x007","O82.100","O43.807","O34.000x013","O82.000","O99.108","O00.116","O03.900x001","O70.200","Z35.200x003","O43.004","O99.620","O06.000","Z35.200x002","O07.300x002","O00.103","O61.900","O00.115","O04.800x031","Z36.300x002","Z35.700","A34.x00","O05.301","O99.225","O07.100x001","O08.006","O62.402","O23.503","O43.806","O98.401","O34.601","O99.204","O44.103","O88.000","O88.201","O08.302","O70.000x005","O08.600x005","O29.100x002","O81.301","O36.800","O99.434","O98.800x013","O16.x00","O98.200x021","O04.502","O34.701","O99.700x010","O73.000","O10.101","O21.100x004","O75.900","O35.202","O34.001","O02.900","O72.000x003","O99.509","O07.700","O06.700","O99.005","Z38.600x001","O05.500","O71.100x001","O99.427","O99.800x033","O98.810","O43.803","Z37.700","O72.202","O43.102","O34.500x005","O64.101","O89.200","O99.100x005","O43.200x001","Z35.801","O63.100","O34.400x013","O99.600x017","O34.100x011","O99.600x012","O35.204","O62.300","O99.800x018","O99.109","O34.400x011","O68.300x001","O34.100x001","O98.803","O00.104","O99.615","O35.814","O66.500x002","O99.004","O99.800x412","O26.609","O29.600","O03.602","O35.807","O99.100x013","O99.618","O69.301","O98.808","Z37.900x003","O33.300x004","O43.112","Z37.201","O03.802","O45.900","O99.806","O00.110","O35.801","O90.800x005","O99.701","Z37.002","O60.100x001","O74.200x001","O71.101","O63.002","O34.804","O99.101","O35.201","O99.423","O63.901","O03.603","O99.210","O41.800","O15.001","O03.801","O65.401","O26.800x016","O72.001","O99.100x012","O86.201","O99.800x114","O99.800x112","O99.202","O99.307","O34.400x010","Z38.300x001","O89.500","O92.300","O66.300x006","O34.404","O36.202","O99.420","O99.702","O43.003","O99.200x002","O99.512","Z39.000x031","O99.432","O88.300x001","O26.800","O28.501","O34.800x019","O98.506","O75.600","O41.101","O03.502","O00.800x006","O90.300","O99.400x010","O98.800x007","O03.902","O89.800","O35.004","O36.501","O74.800","Z35.600x001","O98.301","O99.705","O99.400x023","O70.000","O87.900","O62.405","O34.800x012","O99.200x011","O99.223","O26.605","Z35.806","O35.700x003","O99.102","O14.100x002","O72.301","O99.310","O44.100x001","O35.300x003","O43.103","O99.421","Z35.208","Z38.800x001","O98.502","O03.102","O74.700","O98.600","O99.305","O60.100x002","O22.103","O03.100x001","O87.100","Z35.300x002","O99.403","O31.000","O06.400","O00.201","O83.101","O13.x00","O99.306","Z36.802","O36.002","O67.000x002","O99.212","O00.900","O21.100x002","O99.105","O23.500x002","O60.001","O64.200x002","O62.202","O03.504","O63.000","O69.800x005","O99.810","O07.300x001","O99.800x314","Z36.900","O08.600x006","O43.200","O71.702","O00.117","O74.000x002","O32.201","O30.100","O86.000","O71.001","O84.100","O08.204","O62.800","O99.500x031","O35.800x015","O22.900","O66.500x001","O35.203","O70.300x002","O34.000x012","O22.102","O69.204","O62.001","O35.800x018","Z37.203","O41.803","O99.418","Z34.900x001","O68.003","O82.900","O69.208","O99.100x023","O99.801","O34.900","O99.220","O46.000x003","O35.818","O03.800","O34.003","O99.003","O99.800x012","O86.401","O34.101","O99.800x122","O85.x00","O03.701","O41.800x001","O05.000","O99.429","O26.806","O04.802","O31.800x007","O45.801","O04.701","O33.600","O35.800x029","O87.301","O99.709","O69.002","O63.201","O98.300x013","O99.400x008","O35.812","O43.805","O34.800","O89.600","O69.900x001","O99.007","O35.806","O34.600x004","O35.804","O33.000x002","O34.800x014","O87.900x003","O33.700","O45.001","O07.300","O74.400","O00.807","O99.309","O23.506","O28.300","Z35.900","O26.603","O36.101","O00.803","O08.000x002","O66.800","O99.800x019","O08.000x004","O46.801","O08.004","O42.900","O99.510","O36.001","O75.000","O65.301","Z39.000x011","O34.800x010","O08.300x004","O98.403","O03.901","O98.804","O04.900x001","O69.201","O36.100","O06.100","O99.100x022","O34.600x005","O99.807","O99.802","O69.503","O99.805","Z36.101","O99.804","O98.501","O66.300x002","O31.800","Z36.500","O83.200","O75.300x002","O99.200x021","Z37.200x003","O92.500x002","O22.500","O99.700x013","O99.311","O44.101","O74.600","Z37.200","O99.508","O99.424","O83.900","O26.602","O35.205","O99.700x012","O99.300x012","O42.000x001","O62.900","O99.622","O99.813","O43.005","Z35.401","O72.002","O22.101","O99.216","O23.000x001","O08.102","O88.100","O34.803","O28.400","Z35.400x001","O64.802","O41.100","O99.800x411","O72.100","O04.700x001","O33.002","O94.x00","O99.703","O99.708","O74.000x001","O90.800x008","Z36.800x002","O87.801","O99.800x431","Z35.102","O75.403","O34.800x013","O99.433","O47.900x002","O43.100","O24.300x001","O08.005","O66.300x003","O99.601","O26.604","O26.600x010","O66.300x007","O83.000","O70.300","O34.500x007","O00.000","O92.000","O02.001","O35.008","O34.800x022","O66.300x001","O24.000x021","O99.800x034","O35.500","O36.401","O44.001","O08.000x010","Z37.400","O35.700x002","O43.900","O04.801","O07.401","O64.100x002","O24.000","O91.001","O22.901","O65.000x001","O99.800x213","O35.003","O98.805","O08.000x009","Z35.207","O86.402","O33.700x004","O89.000x003","O22.300","O61.100","O34.400x005","O92.600","O98.601","O26.300","O64.100x003","O83.800","O69.203","O89.100x002","O08.602","O99.500x011","Z38.000x001","O28.200","O98.800x035","O99.511","O36.302","O97.100","Z35.100x001","O71.403","O43.104","O34.000x008","O42.000x002","O65.000x002","O98.300","O99.400x004","O89.400","O29.000x005","O08.106","O03.604","Z36.301","O75.200","O35.800x003","O70.200x003","O35.810","O35.400","O99.200x018","O08.100x004","O65.501","O99.416","O99.616","O07.900x001","O01.901","O14.900","O70.100x005","O01.101","O62.404","O08.500","O33.300x005","O80.000","O99.800","Z36.800x001","O71.801","O04.601","O71.500","O03.904","Z37.501","O20.000","O23.101","O32.500","O41.000","O99.426","O00.200","O14.000x002","O65.001","O64.002","O31.800x003","O35.808","O99.201","O99.605","O32.802","O99.800x321","O04.905","O04.800","O99.300x032","Z35.204","O08.100x002","Z37.100","O69.800x004","O26.000","O99.000x021","O67.900","Z37.303","O69.101","O64.803","O15.900","O99.800x113","O64.801","O73.001","O99.002","O45.000x001","O99.301","O29.000x002","Z37.600x001","O29.300","O99.106","O86.102","O96.900","O00.801","O99.600x014","O87.300","O35.009","O33.102","O81.000","O45.000x003","O32.302","O22.200","O99.800x017","O34.806","O72.201","O99.800x421","O34.700x005","O06.200","Z35.104","O99.800x132","O66.001","O99.600x016","O70.100x003","O44.000x003","O29.200","O08.301","O08.100x003","O92.100x001","O11.x01","O35.809","O99.203","O33.800","O10.201","O64.401","O87.200","O03.702","O75.801","O35.800x025","O04.300x041","O99.422","O99.431","O99.619","O69.400","Z37.202","O90.201","O35.800x012","O99.800x312","O99.103","O99.800x021","O35.007","O68.002","O34.807","O99.400x032","O28.900","O23.500x010","O63.003","O33.301","O03.002","O99.206","O08.800x007","O08.802","O98.200","O75.800x004","O42.100x012","O44.002","O35.800x028","O43.101","Z37.900","O35.819","O44.102","O34.406","O92.700x002","O32.202","O34.000x003","O99.800x116","O99.500x008","O99.707","O31.100","O35.101","O69.500x003","O99.800x031","Z35.103","O34.503","O26.100","O08.202","O99.219","O42.200x001","O65.800","O99.617","O34.403","O71.201","O99.803","O05.200","O71.700x002","O43.802","O64.001","O71.704","O81.200","O99.505","O48.x00","O24.100x021","O91.200x005","O99.607","O23.505","O88.800x001","O01.902","O22.400","O35.700x006","O41.102","O00.113","O98.500","Z37.300","O69.802","O99.800x216","O60.300x002","O03.101","O66.300x005","Z38.400x001","O35.816","O35.823","O35.800x007","O07.200x001","O13.x01","Z38.700x001","O05.801","O34.604","O60.300x001","O04.100x002","O15.101","O80.900","O99.800x315","O36.100x002","O91.200x001","O99.800x414","O82.201","O34.501","O00.106","O34.502","O75.300x001","O35.800x009","O22.902","O99.609","O34.603","O36.504","O90.102","O99.419","O84.000","O29.100x001","O04.902","O23.901","O84.900","Z35.203","O34.700x002","O71.700x001","Z37.500","O69.206","O22.801","O84.800","O68.901","O99.430","Z36.001","O65.300x002","O98.000x031","O30.900","O64.301","O92.100","O99.400x021","O99.300x031","O08.806","O45.000x004","O26.501","O99.404","O32.601","O70.000x002","O04.402","O26.800x013","O75.700x001","O24.100x011","O99.800x417","Z37.700x001","O23.500x001","O91.200x003","O32.401","O35.700x001","O03.300x031","O04.400","O34.402","O04.503","O99.507","O24.100","O99.221","O99.800x415","O28.300x001","O23.400","O01.001","O99.504","O14.000x001","Z35.500x001","O15.201","Z37.000x001","O00.108","O36.300x008","O90.801","O07.800","O34.401","O35.102","O47.900","O99.406","O04.401","O35.800x023","O98.201","O72.300x002","O02.100x002","O23.300","O62.403","O06.600","O68.001","O03.300","O70.000x003","O08.000x006","O69.207","O99.411","O14.200","O46.001","Z35.802","O70.100","O99.800x016","O92.701","O26.600x011","O99.614","O98.800","O70.900","Z37.001","O34.500x001","O85.x00x006","O08.604","O99.800x221","O95.x00","O03.001","O99.401","O07.402","Z35.000","O99.214","O81.500","O70.100x002","Z35.209","O99.215","O89.000x001","O44.100","O69.501","O85.x03","O34.801","O99.812","O87.000","O34.805","O99.610","O29.400","O62.400x007","O34.100x003","O35.805","O99.402","O99.706","O34.500x002","O06.301","O99.313","O34.800x021","O97.000","O99.413","O99.800x121","O34.700x004","O03.900x002","O69.500x004","O72.300","O06.900","Z37.502","O81.401","O91.102","O66.901","Z34.800","O64.501","O92.500x001","O32.303","O35.600x001","O99.502","O73.102","O62.201","O00.100","O32.900","O99.800x231","O35.005","O69.200x006","O04.300","Z39.000x001","O35.206","O62.101","O26.802","O98.101","O29.900","Z35.206","O86.100x002","O99.800x211","O99.400x011","O31.800x005","O90.800x009","Z37.600","O99.800x331","O32.101","O69.200x007","O34.800x017","O32.803","O08.200x002","O90.800x007","O98.100x021","O35.300x002","O98.302","O99.800x317","Z35.202","O67.000","O89.000x002","O05.400","O03.800x041","O23.501","O46.000","Z38.200x001","O99.200x017","O30.000","O87.901","O90.202","O80.800","O75.500","O64.800","O64.900","Z36.801","O96.000","O83.300","O26.607","O46.900","O98.402","O34.405","O04.901","O43.107","O73.002","O03.400x001","O99.300x021","O90.000","O08.300x003","O99.600x001","O99.800x511","O07.000x002","Z35.804","O36.304","O06.801","O00.809","O98.100x031","O43.110","O99.409","O99.425","O46.000x004","O03.300x041","Z36.401","O36.700x001","O05.600","O31.000x001","O99.410","O99.800x318","O91.100x001","O36.201","O04.800x041"};
            String[] dept_list={};
            if (!(true && mdc_zd.Contains(record.zdList[0]))){
                return "";
            }
            
            Base.groupMessages.putMessage(record.Index,"符合MDCO入组条件，匹配规则：主诊断匹配");
            String result;
    
            result=OB1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=OC1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=OD1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=OD2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=OE1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=OF1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=OF2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=OJ1.group(record);
            if (result.Length>0){
                return result;
            }
    
            if (record.ssList!=null && record.ssList.Length>0 && Base.SS_VALID.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合OQY入组条件，存在有效手术操作："+record.ssList.Intersect(Base.SS_VALID));
                return "OQY";
            }
    
            result=OR1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=OS1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=OS2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=OT1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=OZ1.group(record);
            if (result.Length>0){
                return result;
            }
    
            Base.groupMessages.putMessage(record.Index,"不符合MDCO的ADRG入组条件");
            return "";
        }
    }
}
