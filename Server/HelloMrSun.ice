module HelloMrSun
{
	["clr:generic:List"] sequence<string> Materials;

	interface Manufacturer
	{
		bool SendMaterials(Materials materials);
	}

}
