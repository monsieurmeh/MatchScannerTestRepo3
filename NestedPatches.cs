[HarmonyPatch("TLDModCompatibilityChecker", "TLDModCompatibilityChecker.NameNameWithClass")]
[HarmonyPatch("TLDModCompatibilityChecker", "TLDModCompatibilityChecker.NameNameTypeWithClass", new Type[] { typeof(int), typeof(string) })]
[HarmonyPatch("TLDModCompatibilityChecker", nameof(TLDModCompatibilityChecker.NameNameOfWithClass))]
[HarmonyPatch("TLDModCompatibilityChecker", nameof(TLDModCompatibilityChecker.NameNameOfTypeWithClass), new Type[] { typeof(int), typeof(string) })]
[HarmonyPatch(nameof(TLDModCompatibilityChecker), "TLDModCompatibilityChecker.NameOfNameWithClass")]
[HarmonyPatch(nameof(TLDModCompatibilityChecker), "TLDModCompatibilityChecker.NameOfNameTypeWithClass", new Type[] { typeof(int), typeof(string) })]
[HarmonyPatch(nameof(TLDModCompatibilityChecker), nameof(TLDModCompatibilityChecker.NameOfNameOfWithClass))]
[HarmonyPatch(nameof(TLDModCompatibilityChecker), nameof(TLDModCompatibilityChecker.NameOfNameOfTypeWithClass), new Type[] { typeof(int), typeof(string) })]
[HarmonyPatch(typeof(TLDModCompatibilityChecker), "TLDModCompatibilityChecker.TypeOfNameWithClass")]
[HarmonyPatch(typeof(TLDModCompatibilityChecker), "TLDModCompatibilityChecker.TypeOfNameTypeWithClass", new Type[] { typeof(int), typeof(string) })]
[HarmonyPatch(typeof(TLDModCompatibilityChecker), nameof(TLDModCompatibilityChecker.TypeOfNameOfWithClass))]
[HarmonyPatch(typeof(TLDModCompatibilityChecker), nameof(TLDModCompatibilityChecker.TypeOfNameOfTypeWithClass), new Type[] { typeof(int), typeof(string) })]
[HarmonyPatch(typeof(TLDModCompatibilityChecker.Intermediate1.Intermediate2.Intermediate3), nameof(Intermediate2.Intermediate3.TypeOfNameOfWithIntermediates))]
[HarmonyPatch("TLDModCompatibilityChecker.Intermediate1.Intermediate2.Intermediate3", "Intermediate2.Intermediate3.NameNameWithIntermediates")]
[HarmonyPatch("TLDModCompatibilityChecker.Intermediate1.Intermediate2.Intermediate3", "Intermediate2.Intermediate3.NameNameTypeWithIntermediates", new Type[] { typeof(int), typeof(string) })]
[HarmonyPatch("TLDModCompatibilityChecker.Intermediate1.Intermediate2.Intermediate3", nameof(Intermediate2.Intermediate3.NameNameOfWithIntermediates))]
[HarmonyPatch("TLDModCompatibilityChecker.Intermediate1.Intermediate2.Intermediate3", nameof(Intermediate2.Intermediate3.NameNameOfTypeWithIntermediates), new Type[] { typeof(int), typeof(string) })]
[HarmonyPatch(nameof(TLDModCompatibilityChecker.Intermediate1.Intermediate2.Intermediate3), "Intermediate2.Intermediate3.NameOfNameWithIntermediates")]
[HarmonyPatch(nameof(TLDModCompatibilityChecker.Intermediate1.Intermediate2.Intermediate3), "Intermediate2.Intermediate3.NameOfNameTypeWithIntermediates", new Type[] { typeof(int), typeof(string) })]
[HarmonyPatch(nameof(TLDModCompatibilityChecker.Intermediate1.Intermediate2.Intermediate3), nameof(Intermediate2.Intermediate3.NameOfNameOfWithIntermediates))]
[HarmonyPatch(nameof(TLDModCompatibilityChecker.Intermediate1.Intermediate2.Intermediate3), nameof(Intermediate2.Intermediate3.NameOfNameOfTypeWithIntermediates), new Type[] { typeof(int), typeof(string) })]
[HarmonyPatch(typeof(TLDModCompatibilityChecker.Intermediate1.Intermediate2.Intermediate3), "Intermediate2.Intermediate3.TypeOfNameWithIntermediates")]
[HarmonyPatch(typeof(TLDModCompatibilityChecker.Intermediate1.Intermediate2.Intermediate3), "Intermediate2.Intermediate3.TypeOfNameTypeWithIntermediates", new Type[] { typeof(int), typeof(string) })]
[HarmonyPatch(typeof(TLDModCompatibilityChecker.Intermediate1.Intermediate2.Intermediate3), nameof(Intermediate2.Intermediate3.TypeOfNameOfWithIntermediates))]
[HarmonyPatch(typeof(TLDModCompatibilityChecker.Intermediate1.Intermediate2.Intermediate3), nameof(Intermediate2.Intermediate3.TypeOfNameOfTypeWithIntermediates), new Type[] { typeof(int), typeof(string) })]
[HarmonyPatch("TLDModCompatibilityChecker.Intermediate1.Intermediate2.Intermediate3", "TLDModCompatibilityChecker.Intermediate1.Intermediate2.Intermediate3.NameNameWithClassWithIntermediates")]
