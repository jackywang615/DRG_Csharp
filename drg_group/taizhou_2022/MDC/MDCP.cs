namespace drg_group.taizhou_2022
{
    public class MDCP
    {
        public static String group(MedicalRecord record){
            String[] mdc_zd={"P76.100","P96.804","P11.100","P77.x01","P58.401","P15.100","P91.802","P10.300","P12.201","P83.901","P61.401","P05.001","P59.901","P78.300x004","P56.900","P50.400","P36.800x001","P96.803","P10.100","P35.401","P91.500","Q87.300x301","P55.101","P37.800x002","P91.600","P74.900","P58.402","P92.200","Q86.200","Q89.002","P28.000","P15.000","P24.001","P70.200","P04.102","P38.x01","P61.001","P83.500","P91.801","P23.600x001","P04.800x001","P52.300","P27.802","P04.200","P21.101","P24.800","P35.100","P59.203","P14.200","A04.301","P36.301","P52.500","P39.100x003","P72.200x001","P55.002","P25.300","P74.202","P59.000","P15.802","P51.900","P39.900","P80.800x001","P78.801","P39.101","P24.200","P35.900","P13.900","P23.600","P81.000","P24.900","P92.000","P05.200","P53.x00x002","P57.000","P50.500","P74.501","P39.300","P15.801","P74.401","P11.500x003","P91.400","P28.302","P24.002","P78.002","P14.000","P15.803","P59.100","P29.301","P78.800x007","P22.900","P57.900","P96.100x001","P58.403","P07.300x011","P94.200x001","P24.102","P54.500","P35.900x001","P36.000","P39.800x007","P81.901","P28.801","P10.000","P22.000x001","P29.800x902","P83.800x007","P78.800x004","P28.900","P39.800x005","P92.100x001","Q89.001","P78.803","P07.300x021","P61.200","P61.900","P55.000x002","P11.300","A04.100x002","P59.801","Q87.300x902","P74.400","P96.300","P72.800","P81.902","P91.200","P26.100","P78.805","P29.800x201","P58.300","P71.800","P15.500","P36.900","P71.400","R95.900","P28.800x901","P72.000","P20.901","P08.100x002","P59.201","P50.300","P24.101","P53.x00x001","P25.200","P27.801","P51.000","P55.900","P39.401","P39.102","P36.902","P70.401","P54.200","P96.100x002","P29.000","P61.800","P08.200x002","P76.801","P11.101","P70.400x001","P12.400","P54.800x002","P93.x00","P78.804","P59.902","P54.400","P28.303","P22.000","P23.400","P74.802","P54.100","P54.800x003","P13.000","P14.300","P15.600","P04.800","P58.900","P50.100","P39.403","E84.101+P75*","P52.200x002","P07.102","P70.900","P36.500","P54.900","P37.900","P20.100","P78.806","P54.600","P76.900","P07.300x001","P07.101","P13.100","P52.100","P55.800x002","P39.402","P61.500","P94.800","P04.001","P90.x00","P12.300","P28.301","P29.200","P72.900","P52.801","P27.000x001","P10.200","P96.200","P96.000x002","P37.200","P74.201","P36.101","P11.200","P39.800x008","P71.200","P52.000","P24.901","P76.200","P71.902","P14.100","P78.000x003","P52.600x001","P36.800x004","P58.800","P15.300","P20.900","P78.000x007","Q87.300x901","P37.901","A54.301+H13.1*","P78.800x009","P29.400","P92.900","P56.000","P36.800x002","P23.000x001","A09.900x005","P39.200","P51.801","P70.801","P74.301","P71.100","P59.202","P28.102","P55.001","P92.300","P57.800","P04.101","P13.801","P78.800x010","P91.900x001","P29.100","P83.803","P78.001","P83.301","P72.100","P28.402","P29.300","P58.100","P70.000","A33.x00","P92.800x001","P96.000x001","P35.000x001","P36.901","E55.000x006","P11.900x001","P07.200x011","P83.801","P12.900","P29.800x901","P28.300","P26.800","P36.800x005","P74.402","P83.000","P39.000","P50.200","P74.302","P50.000","P23.200","P04.900","P96.400","P71.901","P07.200","P37.400","P22.100x003","P74.100","P21.900x002","P83.500x002","P61.100","P54.300x003","P29.900","P92.001","A04.000x001","P07.300","P94.200x002","P39.100x004","P14.800x002","Q86.000","P39.801","P23.500","P96.301","P92.400","P55.801","P21.900","P78.800x008","P23.300","P07.200x021","L01.006","P27.900","P92.800x003","P52.600x002","Q89.000","P59.301","P25.000","P27.000","P76.000","P52.400","P13.800","P71.000","P12.801","P78.300x003","P78.901","P14.900","Q89.801","P24.300","P28.500","P52.200x001","P39.800x006","P70.400x002","P83.600","Q89.400","P91.700","P83.800x004","P12.000x001","P38.x00x001","P23.100","P07.002","P25.100","P78.300x005","P94.100x001","P05.102","P54.300x001","P37.800x001","P81.001","P96.800x904","P23.600x002","P58.800x001","P80.900","P23.600x004","P36.800x003","P29.401","P14.800x001","P15.804","P28.800x903","P23.600x003","P05.900x001","Q27.000","P83.802","P78.800x012","P96.900x001","P95.x00","P04.500","P78.000x005","P36.200","P28.800x101","A04.402","P57.901","P96.500","P23.900","P20.000","P15.400","Q86.100","P28.401","P61.300","P93.x01","P58.200","Q89.003","P78.300x002","P26.000","P13.400","P83.800x006","P35.800x001","P15.800x004","P05.900","P83.100","P91.800x001","P80.801","P91.100","P91.900","P78.802","P78.800x006","P29.802","P54.802","P35.300","P78.800x005","P04.600","P07.100","P11.400","P35.200","P94.000","P21.102","P91.000x002","P50.900","P35.400","A04.200x002","P83.800x005","P74.001","P96.801","P78.100x001","P55.102","P21.000","P13.300","R95.000","P83.400","P35.000","P52.802","P92.500","P07.000","P93.x02","P74.403","A04.400x003","P28.800x202","P83.302","P26.900","P61.000","P78.900","P91.300","P96.800x101","P94.900","P70.300","P28.400","P11.500x002","P37.500","P07.001","P08.100x001","P83.500x003","P23.800","P10.901","P70.100","P13.200","P78.000x004","P13.301","P36.400","P08.000","P74.800x003","P54.000","P15.900","P71.100x001","P58.000","P81.800","P04.400","P96.802","P74.801","P25.801","P27.100","P15.901","P54.801","K10.200x009","P74.002","P54.300x002","P78.000x006","P28.200","P04.300","P71.300x001","P78.200x001","P61.601","P10.400","P80.000","P22.101","P12.100","P78.807","L00.x01","P50.800","P10.800","P39.800x004","P83.200","P83.401","P22.801","P11.000","P15.201","P58.500","P78.300x001","P52.900","P60.x00","P28.800x201"};
            String[] dept_list={};
            if (!(true && mdc_zd.Contains(record.zdList[0]) && record.age==0)){
                return "";
            }
            
            Base.groupMessages.putMessage(record.Index,"符合MDCP入组条件，匹配规则：主诊断匹配、婴儿");
            String result;
    
            result=PB1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=PC1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=PJ1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=PK1.group(record);
            if (result.Length>0){
                return result;
            }
    
            if (false && record.ssList!=null && record.ssList.Length>0  && Base.intersect(Base.SS_VALID,record.ssList)){
                Base.groupMessages.putMessage(record.Index,"符合PQY入组条件，存在有效手术操作："+record.ssList.Intersect(Base.SS_VALID));
                return "PQY";
            }
    
            result=PR1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=PS1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=PS2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=PS3.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=PS4.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=PU1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=PV1.group(record);
            if (result.Length>0){
                return result;
            }
    
            Base.groupMessages.putMessage(record.Index,"不符合MDCP的ADRG入组条件");
            return "";
        }
    }
}