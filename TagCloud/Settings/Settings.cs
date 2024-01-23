using CommandLine;

namespace TagCloud.Settings;

public class Settings : IAppSettings
{
    [Option('s', "sourceFile", Default = "text.txt", HelpText = "Path to file with words to visualize")]
    public string InputPath { get; set; }
    
    [Option('o', "outputPath", Default = "result", HelpText = "Path to output image file")]
    public string OutputPath { get; set; }
    
    [Option('e', "extensionImage", Default = "png", HelpText = "Output image file format")]
    public string ImageExtension { get; set; }
    
    [Option('f', "fontType", Default = "Roboto", HelpText = "Font type of words")]
    public string FontType { get; set; }
    
    [Option('W', "width", Default = 1920, HelpText = "Width of cloud")]
    public int CloudWidth { get; set; }
    
    [Option('H', "height", Default = 1080, HelpText = "Height of cloud")]
    public int CloudHeight { get; set; }
    
    [Option('l', "layouter", Default = "Circular", HelpText = "Cloud layouter algorithm")]
    public string LayouterType { get; set; }
    
    [Option('d', "density", Default = 1, HelpText = "Density of cloud")]
    public int CloudDensity { get; set; }
}