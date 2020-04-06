import xlrd

loc = ("Languages.xlsx")

LocalizationFile = open("Localization_GENERATED.cs","w", encoding="utf-8")
wb = xlrd.open_workbook(loc)
sheet = wb.sheet_by_index(0)

# For row 0 and column 0
sheet.cell_value(0, 0)

LocalizationFile.write("using System.Collections.Generic;\n")
LocalizationFile.write("using System.Linq;\n")
LocalizationFile.write("using UnityEngine;\n")
LocalizationFile.write("\n")
LocalizationFile.write("public static class Localization\n")
LocalizationFile.write("{\n")
LocalizationFile.write("\n")
LocalizationFile.write("    static bool SafeMode = true; //IF TRANSLATE ERROR, WON'T ATTEMPT TO TRANSLATE THE FAILED STRING.\n")
LocalizationFile.write("\n")



# EN_TR
LocalizationFile.write("    public static Dictionary<string, string> TR = new Dictionary<string, string>()\n")
LocalizationFile.write("    {\n")
for i in range(sheet.nrows):
    if("//" in str(sheet.cell_value(i, 0)).strip()):
        LocalizationFile.write("\t\t" + (str(sheet.cell_value(i, 0) + "\n")))
    else:
        LocalizationFile.write("\t\t{\"%s\", \"%s\" },\n" % (str(sheet.cell_value(i, 0)).strip(),str(sheet.cell_value(i, 1)).strip()))
LocalizationFile.write("\t\t{\"\", \"\" }\n")
LocalizationFile.write("    };\n")

# EN_ESP
LocalizationFile.write("    public static Dictionary<string, string> ESP = new Dictionary<string, string>()\n")
LocalizationFile.write("    {\n")
for i in range(sheet.nrows):
    if("//" in str(sheet.cell_value(i, 0)).strip()): 
        LocalizationFile.write("\t\t" + (str(sheet.cell_value(i, 0) + "\n")))
    else:
        LocalizationFile.write("\t\t{\"%s\", \"%s\" },\n" % (str(sheet.cell_value(i, 0)).strip(),str(sheet.cell_value(i, 2)).strip()))
LocalizationFile.write("\t\t{\"\", \"\" }\n")
LocalizationFile.write("    };\n")

# EN_DE
LocalizationFile.write("    public static Dictionary<string, string> DE = new Dictionary<string, string>()\n")
LocalizationFile.write("    {\n")
for i in range(sheet.nrows):
    if("//" in str(sheet.cell_value(i, 0)).strip()): 
        LocalizationFile.write("\t\t" + (str(sheet.cell_value(i, 0) + "\n")))
    else:
        LocalizationFile.write("\t\t{\"%s\", \"%s\" },\n" % (str(sheet.cell_value(i, 0)).strip(),str(sheet.cell_value(i, 3)).strip()))
LocalizationFile.write("\t\t{\"\", \"\" }\n")
LocalizationFile.write("    };\n")

# EN_RU
LocalizationFile.write("    public static Dictionary<string, string> RU = new Dictionary<string, string>()\n")
LocalizationFile.write("    {\n")
for i in range(sheet.nrows):
    if("//" in str(sheet.cell_value(i, 0)).strip()): 
        LocalizationFile.write("\t\t" + (str(sheet.cell_value(i, 0) + "\n")))
    else:
        LocalizationFile.write("\t\t{\"%s\", \"%s\" },\n" % (str(sheet.cell_value(i, 0)).strip(),str(sheet.cell_value(i, 4)).strip()))
LocalizationFile.write("\t\t{\"\", \"\" }\n")
LocalizationFile.write("    };\n")

# EN_POR
LocalizationFile.write("    public static Dictionary<string, string> POR = new Dictionary<string, string>()\n")
LocalizationFile.write("    {\n")
for i in range(sheet.nrows):
    if("//" in str(sheet.cell_value(i, 0)).strip()): 
        LocalizationFile.write("\t\t" + (str(sheet.cell_value(i, 0) + "\n")))
    else:
        LocalizationFile.write("\t\t{\"%s\", \"%s\" },\n" % (str(sheet.cell_value(i, 0)).strip(),str(sheet.cell_value(i, 5)).strip()))
LocalizationFile.write("\t\t{\"\", \"\" }\n")
LocalizationFile.write("    };\n")

# EN_CN
LocalizationFile.write("    public static Dictionary<string, string> CN = new Dictionary<string, string>()\n")
LocalizationFile.write("    {\n")
for i in range(sheet.nrows):
    if("//" in str(sheet.cell_value(i, 0)).strip()): 
        LocalizationFile.write("\t\t" + (str(sheet.cell_value(i, 0) + "\n")))
    else:
        LocalizationFile.write("\t\t{\"%s\", \"%s\" },\n" % (str(sheet.cell_value(i, 0)).strip(),str(sheet.cell_value(i, 6)).strip()))
LocalizationFile.write("\t\t{\"\", \"\" }\n")
LocalizationFile.write("    };\n")

# EN_FR
LocalizationFile.write("    public static Dictionary<string, string> FR = new Dictionary<string, string>()\n")
LocalizationFile.write("    {\n")
for i in range(sheet.nrows):
    if("//" in str(sheet.cell_value(i, 0)).strip()): 
        LocalizationFile.write("\t\t" + (str(sheet.cell_value(i, 0) + "\n")))
    else:
        LocalizationFile.write("\t\t{\"%s\", \"%s\" },\n" % (str(sheet.cell_value(i, 0)).strip(),str(sheet.cell_value(i, 7)).strip()))
LocalizationFile.write("\t\t{\"\", \"\" }\n")
LocalizationFile.write("    };\n")

LocalizationFile.write("\tpublic static string GetEquivalent(string value, SystemLanguage Lang)\n")
LocalizationFile.write("    {\n")
LocalizationFile.write("        if (SafeMode)\n")
LocalizationFile.write("        {\n")
LocalizationFile.write("            try\n")
LocalizationFile.write("            {\n")
LocalizationFile.write("                switch (Lang)\n")
LocalizationFile.write("                {\n")
LocalizationFile.write("                    case SystemLanguage.Turkish:\n")
LocalizationFile.write("                        return TR[value];\n")
LocalizationFile.write("                    case SystemLanguage.Spanish:\n")
LocalizationFile.write("                        return ESP[value];\n")
LocalizationFile.write("                    case SystemLanguage.German:\n")
LocalizationFile.write("                        return DE[value];\n")
LocalizationFile.write("                    case SystemLanguage.Russian:\n")
LocalizationFile.write("                        return RU[value];\n")
LocalizationFile.write("                    case SystemLanguage.Portuguese:\n")
LocalizationFile.write("                        return POR[value];\n")
LocalizationFile.write("                    case SystemLanguage.Chinese:\n")
LocalizationFile.write("                        return CN[value];\n")
LocalizationFile.write("                    case SystemLanguage.French:\n")
LocalizationFile.write("                        return FR[value];\n")
LocalizationFile.write("                    default:\n")
LocalizationFile.write("                        return value;\n")
LocalizationFile.write("                }\n")
LocalizationFile.write("            }\n")
LocalizationFile.write("            catch (System.Exception)\n")
LocalizationFile.write("            {\n")
LocalizationFile.write("                Debug.LogWarning(value);\n")
LocalizationFile.write("                return value;\n")
LocalizationFile.write("            }\n")
LocalizationFile.write("        }\n")
LocalizationFile.write("        else\n")
LocalizationFile.write("        {\n")
LocalizationFile.write("            switch (Lang)\n")
LocalizationFile.write("            {\n")
LocalizationFile.write("                case SystemLanguage.Turkish:\n")
LocalizationFile.write("                    return TR[value];\n")
LocalizationFile.write("                case SystemLanguage.Spanish:\n")
LocalizationFile.write("                    return ESP[value];\n")
LocalizationFile.write("                case SystemLanguage.German:\n")
LocalizationFile.write("                    return DE[value];\n")
LocalizationFile.write("                case SystemLanguage.Russian:\n")
LocalizationFile.write("                    return RU[value];\n")
LocalizationFile.write("                case SystemLanguage.Portuguese:\n")
LocalizationFile.write("                    return POR[value];\n")
LocalizationFile.write("                case SystemLanguage.Chinese:\n")
LocalizationFile.write("                    return CN[value];\n")
LocalizationFile.write("                case SystemLanguage.French:\n")
LocalizationFile.write("                    return FR[value];\n")
LocalizationFile.write("                default:\n")
LocalizationFile.write("                    return value;\n")
LocalizationFile.write("            }\n")
LocalizationFile.write("        }\n")
LocalizationFile.write("    }\n")
LocalizationFile.write("\n")
LocalizationFile.write("    public static string GetReversedEquivalent(string value, SystemLanguage Lang)\n")
LocalizationFile.write("    {\n")
LocalizationFile.write("        if (SafeMode)\n")
LocalizationFile.write("        {\n")
LocalizationFile.write("            try\n")
LocalizationFile.write("            {\n")
LocalizationFile.write("                switch (Lang)\n")
LocalizationFile.write("                {\n")
LocalizationFile.write("                    case SystemLanguage.Turkish:\n")
LocalizationFile.write("                        return TR.ToDictionary(x => x.Value, x => x.Key)[value];\n")
LocalizationFile.write("                    case SystemLanguage.Spanish:\n")
LocalizationFile.write("                        return ESP.ToDictionary(x => x.Value, x => x.Key)[value];\n")
LocalizationFile.write("                    case SystemLanguage.German:\n")
LocalizationFile.write("                        return DE.ToDictionary(x => x.Value, x => x.Key)[value];\n")
LocalizationFile.write("                    case SystemLanguage.Russian:\n")
LocalizationFile.write("                        return RU.ToDictionary(x => x.Value, x => x.Key)[value];\n")
LocalizationFile.write("                    case SystemLanguage.Portuguese:\n")
LocalizationFile.write("                        return POR.ToDictionary(x => x.Value, x => x.Key)[value];\n")
LocalizationFile.write("                    case SystemLanguage.Chinese:\n")
LocalizationFile.write("                        return CN.ToDictionary(x => x.Value, x => x.Key)[value];\n")
LocalizationFile.write("                    case SystemLanguage.French:\n")
LocalizationFile.write("                        return FR.ToDictionary(x => x.Value, x => x.Key)[value];\n")
LocalizationFile.write("                    default:\n")
LocalizationFile.write("                        return value;\n")
LocalizationFile.write("                }\n")
LocalizationFile.write("            }\n")
LocalizationFile.write("            catch (System.Exception)\n")
LocalizationFile.write("            {\n")
LocalizationFile.write("                Debug.LogWarning(value);\n")
LocalizationFile.write("                return value;\n")
LocalizationFile.write("            }\n")
LocalizationFile.write("        }\n")
LocalizationFile.write("        else\n")
LocalizationFile.write("        {\n")
LocalizationFile.write("            switch (Lang)\n")
LocalizationFile.write("            {\n")
LocalizationFile.write("                case SystemLanguage.Turkish:\n")
LocalizationFile.write("                    return TR.ToDictionary(x => x.Value, x => x.Key)[value];\n")
LocalizationFile.write("                case SystemLanguage.Spanish:\n")
LocalizationFile.write("                    return ESP.ToDictionary(x => x.Value, x => x.Key)[value];\n")
LocalizationFile.write("                case SystemLanguage.German:\n")
LocalizationFile.write("                    return DE.ToDictionary(x => x.Value, x => x.Key)[value];\n")
LocalizationFile.write("                case SystemLanguage.Russian:\n")
LocalizationFile.write("                    return RU.ToDictionary(x => x.Value, x => x.Key)[value];\n")
LocalizationFile.write("                case SystemLanguage.Portuguese:\n")
LocalizationFile.write("                    return POR.ToDictionary(x => x.Value, x => x.Key)[value];\n")
LocalizationFile.write("                case SystemLanguage.Chinese:\n")
LocalizationFile.write("                    return CN.ToDictionary(x => x.Value, x => x.Key)[value];\n")
LocalizationFile.write("                case SystemLanguage.French:\n")
LocalizationFile.write("                    return FR.ToDictionary(x => x.Value, x => x.Key)[value];\n")
LocalizationFile.write("                default:\n")
LocalizationFile.write("                    return value;\n")
LocalizationFile.write("            }\n")
LocalizationFile.write("        }\n")
LocalizationFile.write("    }\n")
LocalizationFile.write("}\n")