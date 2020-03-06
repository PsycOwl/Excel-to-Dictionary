# Program extracting all columns
# name in Python
import xlrd

loc = ("Languages.xlsx")

wb = xlrd.open_workbook(loc)
sheet = wb.sheet_by_index(0)

# For row 0 and column 0
sheet.cell_value(0, 0)

print("using System.Collections.Generic;")
print("using System.Linq;")
print("using UnityEngine;")
print("")
print("public static class Localization")
print("{")
print("")
print("    static bool SafeMode = true; //IF TRANSLATE ERROR, WON'T ATTEMPT TO TRANSLATE THE FAILED STRING.")
print("")



# EN_TR
print("    public static Dictionary<string, string> TR = new Dictionary<string, string>()")
print("    {")
for i in range(sheet.nrows):
    if("//" in sheet.cell_value(i, 0)): 
        print("\t\t" + (sheet.cell_value(i, 0)))
    else:
        print("\t\t{ \"%s\", \"%s\" }," % (sheet.cell_value(i, 0).strip(),sheet.cell_value(i, 1).strip()))
print("\t\t{ \"\", \"\" }")
print("    }")

# EN_ESP
print("    public static Dictionary<string, string> ESP = new Dictionary<string, string>()")
print("    {")
for i in range(sheet.nrows):
    if("//" in sheet.cell_value(i, 0)): 
        print("\t\t" + (sheet.cell_value(i, 0)))
    else:
        print("\t\t{ \"%s\", \"%s\" }," % (sheet.cell_value(i, 0).strip(),sheet.cell_value(i, 2).strip()))
print("\t\t{ \"\", \"\" }")
print("    }")

# EN_DE
print("    public static Dictionary<string, string> DE = new Dictionary<string, string>()")
print("    {")
for i in range(sheet.nrows):
    if("//" in sheet.cell_value(i, 0)): 
        print("\t\t" + (sheet.cell_value(i, 0)))
    else:
        print("\t\t{ \"%s\", \"%s\" }," % (sheet.cell_value(i, 0).strip(),sheet.cell_value(i, 3).strip()))
print("\t\t{ \"\", \"\" }")
print("    }")

# EN_RU
print("    public static Dictionary<string, string> RU = new Dictionary<string, string>()")
print("    {")
for i in range(sheet.nrows):
    if("//" in sheet.cell_value(i, 0)): 
        print("\t\t" + (sheet.cell_value(i, 0)))
    else:
        print("\t\t{ \"%s\", \"%s\" }," % (sheet.cell_value(i, 0).strip(),sheet.cell_value(i, 4).strip()))
print("\t\t{ \"\", \"\" }")
print("    }")

# EN_POR
print("    public static Dictionary<string, string> POR = new Dictionary<string, string>()")
print("    {")
for i in range(sheet.nrows):
    if("//" in sheet.cell_value(i, 0)): 
        print("\t\t" + (sheet.cell_value(i, 0)))
    else:
        print("\t\t{ \"%s\", \"%s\" }," % (sheet.cell_value(i, 0).strip(),sheet.cell_value(i, 5).strip()))
print("\t\t{ \"\", \"\" }")
print("    }")

print("public static string GetEquivalent(string value, SystemLanguage Lang)")
print("    {")
print("        if (SafeMode)")
print("        {")
print("            try")
print("            {")
print("                switch (Lang)")
print("                {")
print("                    case SystemLanguage.Turkish:")
print("                        return TR[value];")
print("                    case SystemLanguage.Spanish:")
print("                        return ESP[value];")
print("                    case SystemLanguage.German:")
print("                        return DE[value];")
print("                    case SystemLanguage.Russian:")
print("                        return RU[value];")
print("                    case SystemLanguage.Portuguese:")
print("                        return POR[value];")
print("                    default:")
print("                        return value;")
print("                }")
print("            }")
print("            catch (System.Exception)")
print("            {")
print("                //Debug.LogWarning(value);")
print("                return value;")
print("            }")
print("        }")
print("        else")
print("        {")
print("            switch (Lang)")
print("            {")
print("                case SystemLanguage.Turkish:")
print("                    return TR[value];")
print("                case SystemLanguage.Spanish:")
print("                    return ESP[value];")
print("                case SystemLanguage.German:")
print("                    return DE[value];")
print("                case SystemLanguage.Russian:")
print("                    return RU[value];")
print("                case SystemLanguage.Portuguese:")
print("                    return POR[value];")
print("                default:")
print("                    return value;")
print("            }")
print("        }")
print("    }")
print("")
print("    public static string GetReversedEquivalent(string value, SystemLanguage Lang)")
print("    {")
print("        if (SafeMode)")
print("        {")
print("            try")
print("            {")
print("                switch (Lang)")
print("                {")
print("                    case SystemLanguage.Turkish:")
print("                        return TR.ToDictionary(x => x.Value, x => x.Key)[value];")
print("                    case SystemLanguage.Spanish:")
print("                        return ESP.ToDictionary(x => x.Value, x => x.Key)[value];")
print("                    case SystemLanguage.German:")
print("                        return DE.ToDictionary(x => x.Value, x => x.Key)[value];")
print("                    case SystemLanguage.Russian:")
print("                        return RU.ToDictionary(x => x.Value, x => x.Key)[value];")
print("                    case SystemLanguage.Portuguese:")
print("                        return POR.ToDictionary(x => x.Value, x => x.Key)[value];")
print("                    default:")
print("                        return value;")
print("                }")
print("            }")
print("            catch (System.Exception)")
print("            {")
print("                //Debug.LogWarning(value);")
print("                return value;")
print("            }")
print("        }")
print("        else")
print("        {")
print("            switch (Lang)")
print("            {")
print("                case SystemLanguage.Turkish:")
print("                    return TR.ToDictionary(x => x.Value, x => x.Key)[value];")
print("                case SystemLanguage.Spanish:")
print("                    return ESP.ToDictionary(x => x.Value, x => x.Key)[value];")
print("                case SystemLanguage.German:")
print("                    return DE.ToDictionary(x => x.Value, x => x.Key)[value];")
print("                case SystemLanguage.Russian:")
print("                    return RU.ToDictionary(x => x.Value, x => x.Key)[value];")
print("                case SystemLanguage.Portuguese:")
print("                    return POR.ToDictionary(x => x.Value, x => x.Key)[value];")
print("                default:")
print("                    return value;")
print("            }")
print("        }")
print("    }")
print("}")