using MudBlazor;

namespace TheMemoAnaGame;

public static class GameTheme
{
    public static readonly MudTheme Theme = new()
    {
        PaletteLight = new PaletteLight()
        {
            Primary = "#8B4513",         
            Secondary = "#C65D2E",       
            Tertiary = "#E0A458",        

            Background = "#F2E6D8",      
            Surface = "#DAD7CD",         
            AppbarBackground = "#8B4513",
            AppbarText = "#F2E6D8",      
            DrawerBackground = "#F2E6D8",
            DrawerText = "#5E3023",

            TextPrimary = "#1F1B16",     
            TextSecondary = "#2B2118",   

            Success = "#6A994E",         
            Error = "#A44A3F",           
            Warning = "#E0A458",         
            Info = "#4F5D90",            

            LinesDefault = "#E0D1B8",
            Divider = "#E0D1B8",
            ActionDefault = "#8B4513",
            ActionDisabled = "#A98467"
        },

        PaletteDark = new PaletteDark()
        {
            Primary = "#DDA15E",           
            Secondary = "#F4A261",         
            Tertiary = "#E9C46A",          
            
            Background = "#181512",        
            Surface = "#241F1A",           
            AppbarBackground = "#1F1B17",  
            AppbarText = "#F2E6D8",        
            DrawerBackground = "#1C1814",  
            DrawerText = "#EDE0D4",        
            
            TextPrimary = "#F7EDE2",  
            TextSecondary = "#CBBBAA",


            Success = "#81C784",           
            Error = "#E57373",             
            Warning = "#F6BD60",           
            Info = "#7E90BF",              

            LinesDefault = "#3D352E",      
            Divider = "#3D352E",           
            ActionDefault = "#DDA15E",     
            ActionDisabled = "#5C5248"     
        },

        Typography = new Typography()
        {
            Default = new DefaultTypography()
            {
                FontFamily = ["Georgia", "Merriweather", "serif"], 
                FontSize = "1rem",
                FontWeight = "400",
                LineHeight = "1.5",
                LetterSpacing = ".00938em"
            },
            H1 = new H1Typography() { FontFamily = ["Cinzel", "Georgia", "serif"], FontWeight = "700" },
            H2 = new H2Typography() { FontFamily = ["Cinzel", "Georgia", "serif"], FontWeight = "600" },
            H3 = new H3Typography() { FontFamily = ["Cinzel", "Georgia", "serif"], FontWeight = "500" },
            Button = new ButtonTypography()
            {
                FontFamily = ["Georgia", "serif"],
                FontWeight = "600",
                TextTransform = "none" 
            }
        },

        LayoutProperties = new LayoutProperties()
        {
            DefaultBorderRadius = "8px", 
            AppbarHeight = "72px" 
        }
    };
}
