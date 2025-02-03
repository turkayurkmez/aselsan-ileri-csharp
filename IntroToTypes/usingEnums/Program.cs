// See https://aka.ms/new-console-template for more information
using usingEnums;

Console.WriteLine("Hello, World!");
DocumentState state = DocumentState.Open;

if (state == DocumentState.Draft)
{

}


switch (state)
{
	case DocumentState.Open:
		break;
	case DocumentState.Closed:
		break;
	case DocumentState.Pending:
		break;
	case DocumentState.Draft:
		break;
	case DocumentState.Published:
		break;
	default:
		break;
}


ErkekAkrabalikTipleri tip = ErkekAkrabalikTipleri.Baba | ErkekAkrabalikTipleri.Amca | ErkekAkrabalikTipleri.Dede | ErkekAkrabalikTipleri.Abi | ErkekAkrabalikTipleri.Dayi;

Console.WriteLine(tip);