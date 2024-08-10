using Converter_Web_Application.Service.Base;

namespace Converter_Web_Application.Service.Implementations
{
    /// <summary>
    /// Conversions strategies
    /// </summary>

    // Sugar Conversions
    // cup of sugar
    public class CupOfSugarToGrams : IConversion
    {
        public int Id => 1;
        public string FromUnit => "cup";
        public string ToUnit => "grams";
        public double Convert(double value) => value * 200;
    }
    public class CupOfSugarToKilograms : IConversion
    {
        public int Id => 2;
        public string FromUnit => "cup";
        public string ToUnit => "kilograms";
        public double Convert(double value) => value * 0.2;
    }
    public class CupOfSugarToOunces : IConversion
    {
        public int Id => 3;
        public string FromUnit => "cup";
        public string ToUnit => "ounces";
        public double Convert(double value) => value * 7.05;
    }
    public class CupOfSugarToPounds : IConversion
    {
        public int Id => 4;
        public string FromUnit => "cup";
        public string ToUnit => "pounds";
        public double Convert(double value) => value * 0.44;
    }

    // Tablespoon of sugar
    public class TablespoonOfSugarToGrams : IConversion
    {
        public int Id => 5;
        public string FromUnit => "tablespoon";
        public string ToUnit => "grams";
        public double Convert(double value) => value * 12.5;
    }
    public class TablespoonOfSugarToKilograms : IConversion
    {
        public int Id => 6;
        public string FromUnit => "tablespoon";
        public string ToUnit => "kilograms";
        public double Convert(double value) => value * 0.0125;
    }
    public class TablespoonOfSugarToOunces : IConversion
    {
        public int Id => 7;
        public string FromUnit => "tablespoon";
        public string ToUnit => "ounces";
        public double Convert(double value) => value * 0.44;
    }
    public class TablespoonOfSugarToPounds : IConversion
    {
        public int Id => 8;
        public string FromUnit => "tablespoon";
        public string ToUnit => "pounds";
        public double Convert(double value) => value * 0.028;
    }

    // teaspoon of sugar
    public class TeaspoonOfSugarToGrams : IConversion
    {
        public int Id => 9;
        public string FromUnit => "teaspoon";
        public string ToUnit => "grams";
        public double Convert(double value) => value * 4.2;
    }
    public class TeaspoonOfSugarToKilograms : IConversion
    {
        public int Id => 10;
        public string FromUnit => "teaspoon";
        public string ToUnit => "kilograms";
        public double Convert(double value) => value * 0.0042;
    }
    public class TeaspoonOfSugarToOunces : IConversion
    {
        public int Id => 11;
        public string FromUnit => "teaspoon";
        public string ToUnit => "ounces";
        public double Convert(double value) => value * 0.15;
    }
    public class TeaspoonOfSugarToPounds : IConversion
    {
        public int Id => 12;
        public string FromUnit => "teaspoon";
        public string ToUnit => "pounds";
        public double Convert(double value) => value * 0.0093;
    }

    // Flour Conversions
    // Cup of flour
    public class CupOfFlourToGrams : IConversion
    {
        public int Id => 13;
        public string FromUnit => "cup";
        public string ToUnit => "grams";
        public double Convert(double value) => value * 120;
    }
    public class CupOfFlourToKilograms : IConversion
    {
        public int Id => 14;
        public string FromUnit => "cup";
        public string ToUnit => "kilograms";
        public double Convert(double value) => value * 0.12;
    }
    public class CupOfFlourToOunces : IConversion
    {
        public int Id => 15;
        public string FromUnit => "cup";
        public string ToUnit => "ounces";
        public double Convert(double value) => value * 4.23;
    }
    public class CupOfFlourToPounds : IConversion
    {
        public int Id => 16;
        public string FromUnit => "cup";
        public string ToUnit => "pounds";
        public double Convert(double value) => value * 0.26;
    }

    // Tablespoon of flour
    public class TablespoonOfFlourToGrams : IConversion
    {
        public int Id => 17;
        public string FromUnit => "tablespoon";
        public string ToUnit => "grams";
        public double Convert(double value) => value * 7.5;
    }
    public class TablespoonOfFlourToKilograms : IConversion
    {
        public int Id => 18;
        public string FromUnit => "tablespoon";
        public string ToUnit => "kilograms";
        public double Convert(double value) => value * 0.0075;
    }
    public class TablespoonOfFlourToOunces : IConversion
    {
        public int Id => 19;
        public string FromUnit => "tablespoon";
        public string ToUnit => "ounces";
        public double Convert(double value) => value * 0.27;
    }
    public class TablespoonOfFlourToPounds : IConversion
    {
        public int Id => 20;
        public string FromUnit => "tablespoon";
        public string ToUnit => "pounds";
        public double Convert(double value) => value * 0.0165;
    }

    // Teaspoon of flour
    public class TeaspoonOfFlourToGrams : IConversion
    {
        public int Id => 21;
        public string FromUnit => "teaspoon";
        public string ToUnit => "grams";
        public double Convert(double value) => value * 2.5;
    }
    public class TeaspoonOfFlourToKilograms : IConversion
    {
        public int Id => 22;
        public string FromUnit => "teaspoon";
        public string ToUnit => "kilograms";
        public double Convert(double value) => value * 0.0025;
    }
    public class TeaspoonOfFlourToOunces : IConversion
    {
        public int Id => 23;
        public string FromUnit => "teaspoon";
        public string ToUnit => "ounces";
        public double Convert(double value) => value * 0.088;
    }
    public class TeaspoonOfFlourToPounds : IConversion
    {
        public int Id => 24;
        public string FromUnit => "teaspoon";
        public string ToUnit => "pounds";
        public double Convert(double value) => value * 0.0055;
    }

    // Butter Conversions
    // cup of butter

    public class CupOfButterToGrams : IConversion
    {
        public int Id => 25;
        public string FromUnit => "cup";
        public string ToUnit => "grams";
        public double Convert(double value) => value * 227;
    }
    public class CupOfButterToKilograms : IConversion
    {
        public int Id => 26;
        public string FromUnit => "cup";
        public string ToUnit => "kilograms";
        public double Convert(double value) => value * 0.227;
    }
    public class CupOfButterToOunces : IConversion
    {
        public int Id => 27;
        public string FromUnit => "cup";
        public string ToUnit => "ounces";
        public double Convert(double value) => value * 8;
    }
    public class CupOfButterToPounds : IConversion
    {
        public int Id => 28;
        public string FromUnit => "cup";
        public string ToUnit => "pounds";
        public double Convert(double value) => value * 0.5;
    }

    // Tablespoon of butter
    public class TablespoonOfButterToGrams : IConversion
    {
        public int Id => 29;
        public string FromUnit => "tablespoon";
        public string ToUnit => "grams";
        public double Convert(double value) => value * 14.2;
    }
    public class TablespoonOfButterToKilograms : IConversion
    {
        public int Id => 30;
        public string FromUnit => "tablespoon";
        public string ToUnit => "kilograms";
        public double Convert(double value) => value * 0.0142;
    }
    public class TablespoonOfButterToOunces : IConversion
    {
        public int Id => 31;
        public string FromUnit => "tablespoon";
        public string ToUnit => "ounces";
        public double Convert(double value) => value * 0.5;
    }
    public class TablespoonOfButterToPounds : IConversion
    {
        public int Id => 32;
        public string FromUnit => "tablespoon";
        public string ToUnit => "pounds";
        public double Convert(double value) => value * 0.03125;
    }

    // Teaspoon of butter
    public class TeaspoonOfButterToGrams : IConversion
    {
        public int Id => 33;
        public string FromUnit => "teaspoon";
        public string ToUnit => "grams";
        public double Convert(double value) => value * 4.7;
    }
    public class TeaspoonOfButterToKilograms : IConversion
    {
        public int Id => 34;
        public string FromUnit => "teaspoon";
        public string ToUnit => "kilograms";
        public double Convert(double value) => value * 0.0047;
    }
    public class TeaspoonOfButterToOunces : IConversion
    {
        public int Id => 35;
        public string FromUnit => "teaspoon";
        public string ToUnit => "ounces";
        public double Convert(double value) => value * 0.167;
    }
    public class TeaspoonOfButterToPounds : IConversion
    {
        public int Id => 36;
        public string FromUnit => "teaspoon";
        public string ToUnit => "pounds";
        public double Convert(double value) => value * 0.0104;
    }

    // Rice Conversions

    // cup of rice
    public class CupOfRiceToGrams : IConversion
    {
        public int Id => 37;
        public string FromUnit => "cup";
        public string ToUnit => "grams";
        public double Convert(double value) => value * 185;
    }
    public class CupOfRiceToKilograms : IConversion
    {
        public int Id => 38;
        public string FromUnit => "cup";
        public string ToUnit => "kilograms";
        public double Convert(double value) => value * 0.185;
    }
    public class CupOfRiceToOunces : IConversion
    {
        public int Id => 39;
        public string FromUnit => "cup";
        public string ToUnit => "ounces";
        public double Convert(double value) => value * 6.53;
    }
    public class CupOfRiceToPounds : IConversion
    {
        public int Id => 40;
        public string FromUnit => "cup";
        public string ToUnit => "pounds";
        public double Convert(double value) => value * 0.41;
    }

    // tablespoon of rice
    public class TablespoonOfRiceToGrams : IConversion
    {
        public int Id => 41;
        public string FromUnit => "tablespoon";
        public string ToUnit => "grams";
        public double Convert(double value) => value * 11.56;
    }
    public class TablespoonOfRiceToKilograms : IConversion
    {
        public int Id => 42;
        public string FromUnit => "tablespoon";
        public string ToUnit => "kilograms";
        public double Convert(double value) => value * 0.01156;
    }
    public class TablespoonOfRiceToOunces : IConversion
    {
        public int Id => 43;
        public string FromUnit => "tablespoon";
        public string ToUnit => "ounces";
        public double Convert(double value) => value * 0.408;
    }
    public class TablespoonOfRiceToPounds : IConversion
    {
        public int Id => 44;
        public string FromUnit => "tablespoon";
        public string ToUnit => "pounds";
        public double Convert(double value) => value * 0.0255;
    }

    // Teaspoon of rice
    public class TeaspoonOfRiceToGrams : IConversion
    {
        public int Id => 73;
        public string FromUnit => "teaspoon";
        public string ToUnit => "grams";
        public double Convert(double value) => value * 3;
    }
    public class TeaspoonOfRiceToKilograms : IConversion
    {
        public int Id => 74;
        public string FromUnit => "teaspoon";
        public string ToUnit => "kilograms";
        public double Convert(double value) => value * 0.003;
    }
    public class TeaspoonOfRiceToOunces : IConversion
    {
        public int Id => 75;
        public string FromUnit => "teaspoon";
        public string ToUnit => "ounces";
        public double Convert(double value) => value * 0.106;
    }
    public class TeaspoonOfRiceToPounds : IConversion
    {
        public int Id => 76;
        public string FromUnit => "teaspoon";
        public string ToUnit => "pounds";
        public double Convert(double value) => value * 0.0066;
    }

    // Water
    // cup of water
    public class CupOfWaterToGrams : IConversion
    {
        public int Id => 77;
        public string FromUnit => "cup";
        public string ToUnit => "grams";
        public double Convert(double value) => value * 240; // 1 cup of water = 240 grams
    }
    public class CupOfWaterToKilograms : IConversion
    {
        public int Id => 78;
        public string FromUnit => "cup";
        public string ToUnit => "kilograms";
        public double Convert(double value) => value * 0.24; // 1 cup of water = 0.24 kilograms
    }
    public class CupOfWaterToOunces : IConversion
    {
        public int Id => 79;
        public string FromUnit => "cup";
        public string ToUnit => "ounces";
        public double Convert(double value) => value * 8.11537; // 1 cup of water = 8.11537 ounces
    }
    public class CupOfWaterToPounds : IConversion
    {
        public int Id => 80;
        public string FromUnit => "cup";
        public string ToUnit => "pounds";
        public double Convert(double value) => value * 0.52; // 1 cup of water = 0.52 pounds
    }
  
   // Tablespoon
    public class TablespoonOfWaterToGrams : IConversion
    {
        public int Id => 65;
        public string FromUnit => "tablespoon";
        public string ToUnit => "grams";
        public double Convert(double value) => value * 15;
    }
    public class TablespoonOfWaterToKilograms : IConversion
    {
        public int Id => 66;
        public string FromUnit => "tablespoon";
        public string ToUnit => "kilograms";
        public double Convert(double value) => value * 0.015;
    }
    public class TablespoonOfWaterToOunces : IConversion
    {
        public int Id => 67;
        public string FromUnit => "tablespoon";
        public string ToUnit => "ounces";
        public double Convert(double value) => value * 0.507;
    }
    public class TablespoonOfWaterToPounds : IConversion
    {
        public int Id => 68;
        public string FromUnit => "tablespoon";
        public string ToUnit => "pounds";
        public double Convert(double value) => value * 0.03125;
    }
    // Teaspoon 
    public class TeaspoonOfWaterToGrams : IConversion
    {
        public int Id => 69;
        public string FromUnit => "teaspoon";
        public string ToUnit => "grams";
        public double Convert(double value) => value * 5;
    }
    public class TeaspoonOfWaterToKilograms : IConversion
    {
        public int Id => 70;
        public string FromUnit => "teaspoon";
        public string ToUnit => "kilograms";
        public double Convert(double value) => value * 0.005;
    }
    public class TeaspoonOfWaterToOunces : IConversion
    {
        public int Id => 71;
        public string FromUnit => "teaspoon";
        public string ToUnit => "ounces";
        public double Convert(double value) => value * 0.169;
    }
    public class TeaspoonOfWaterToPounds : IConversion
    {
        public int Id => 72;
        public string FromUnit => "teaspoon";
        public string ToUnit => "pounds";
        public double Convert(double value) => value * 0.0104;
    }

    // Milk
    // Cup of milk
    public class CupOfMilkToGrams : IConversion
    {
        public int Id => 51;
        public string FromUnit => "cup";
        public string ToUnit => "grams";
        public double Convert(double value) => value * 240; // 1 cup of milk = 240 grams
    }
    public class CupOfMilkToKilograms : IConversion
    {
        public int Id => 52;
        public string FromUnit => "cup";
        public string ToUnit => "kilograms";
        public double Convert(double value) => value * 0.24; // 1 cup of milk = 0.24 kilograms
    }
    public class CupOfMilkToOunces : IConversion
    {
        public int Id => 53;
        public string FromUnit => "cup";
        public string ToUnit => "ounces";
        public double Convert(double value) => value * 8.11; // 1 cup of milk = 8.11 ounces
    }
    public class CupOfMilkToPounds : IConversion
    {
        public int Id => 54;
        public string FromUnit => "cup";
        public string ToUnit => "pounds";
        public double Convert(double value) => value * 0.528; // 1 cup of milk = 0.528 pounds
    }
    // Tablespoon of milk
    public class TablespoonOfMilkToGrams : IConversion
    {
        public int Id => 55;
        public string FromUnit => "tablespoon";
        public string ToUnit => "grams";
        public double Convert(double value) => value * 15; // 1 tablespoon of milk = 15 grams
    }
    public class TablespoonOfMilkToKilograms : IConversion
    {
        public int Id => 56;
        public string FromUnit => "tablespoon";
        public string ToUnit => "kilograms";
        public double Convert(double value) => value * 0.015; // 1 tablespoon of milk = 0.015 kilograms
    }
    public class TablespoonOfMilkToOunces : IConversion
    {
        public int Id => 57;
        public string FromUnit => "tablespoon";
        public string ToUnit => "ounces";
        public double Convert(double value) => value * 0.507; // 1 tablespoon of milk = 0.507 ounces
    }
    public class TablespoonOfMilkToPounds : IConversion
    {
        public int Id => 58;
        public string FromUnit => "tablespoon";
        public string ToUnit => "pounds";
        public double Convert(double value) => value * 0.03125; // 1 tablespoon of milk = 0.03125 pounds
    }

    // Teaspoon of milk
    public class TeaspoonOfMilkToGrams : IConversion
    {
        public int Id => 59;
        public string FromUnit => "teaspoon";
        public string ToUnit => "grams";
        public double Convert(double value) => value * 5; // 1 teaspoon of milk = 5 grams
    }
    public class TeaspoonOfMilkToKilograms : IConversion
    {
        public int Id => 60;
        public string FromUnit => "teaspoon";
        public string ToUnit => "kilograms";
        public double Convert(double value) => value * 0.005; // 1 teaspoon of milk = 0.005 kilograms
    }
    public class TeaspoonOfMilkToOunces : IConversion
    {
        public int Id => 61;
        public string FromUnit => "teaspoon";
        public string ToUnit => "ounces";
        public double Convert(double value) => value * 0.169; // 1 teaspoon of milk = 0.169 ounces
    }
    public class TeaspoonOfMilkToPounds : IConversion
    {
        public int Id => 62;
        public string FromUnit => "teaspoon";
        public string ToUnit => "pounds";
        public double Convert(double value) => value * 0.0104; // 1 teaspoon of milk = 0.0104 pounds
    }


    // Sugar - grams, kilograms, pounds, ounces to...

    // Cups
    public class GramsToCupsOfSugar : IConversion
    {
        public int Id => 101;
        public string FromUnit => "grams";
        public string ToUnit => "sugar";
        public double Convert(double value) => value / 200; // 1 cup of sugar = 200 grams
    }
    public class KilogramsToCupsOfSugar : IConversion
    {
        public int Id => 102;
        public string FromUnit => "kilograms";
        public string ToUnit => "sugar";
        public double Convert(double value) => value / 0.2; // 1 cup of sugar = 0.2 kilograms
    }
    public class OuncesToCupsOfSugar : IConversion
    {
        public int Id => 103;
        public string FromUnit => "ounces";
        public string ToUnit => "sugar";
        public double Convert(double value) => value / 7.05; // 1 cup of sugar = 7.05 ounces
    }
    public class PoundsToCupsOfSugar : IConversion
    {
        public int Id => 104;
        public string FromUnit => "pounds";
        public string ToUnit => "sugar";
        public double Convert(double value) => value / 0.44; // 1 cup of sugar = 0.44 pounds
    }

    // Tablespoons
    public class GramsToTablespoonsOfSugar : IConversion
    {
        public int Id => 105;
        public string FromUnit => "grams";
        public string ToUnit => "sugar";
        public double Convert(double value) => value / 12.5; // 1 tablespoon of sugar = 12.5 grams
    }
    public class KilogramsToTablespoonsOfSugar : IConversion
    {
        public int Id => 106;
        public string FromUnit => "kilograms";
        public string ToUnit => "sugar";
        public double Convert(double value) => value / 0.0125; // 1 tablespoon of sugar = 0.0125 kilograms
    }
    public class OuncesToTablespoonsOfSugar : IConversion
    {
        public int Id => 107;
        public string FromUnit => "ounces";
        public string ToUnit => "sugar";
        public double Convert(double value) => value / 0.44; // 1 tablespoon of sugar = 0.44 ounces
    }
    public class PoundsToTablespoonsOfSugar : IConversion
    {
        public int Id => 108;
        public string FromUnit => "pounds";
        public string ToUnit => "sugar";
        public double Convert(double value) => value / 0.028; // 1 tablespoon of sugar = 0.028 pounds
    }

    // Teaspoons
    public class GramsToTeaspoonsOfSugar : IConversion
    {
        public int Id => 109;
        public string FromUnit => "grams";
        public string ToUnit => "sugar";
        public double Convert(double value) => value / 4.2; // 1 teaspoon of sugar = 4.2 grams
    }
    public class KilogramsToTeaspoonsOfSugar : IConversion
    {
        public int Id => 110;
        public string FromUnit => "kilograms";
        public string ToUnit => "sugar";
        public double Convert(double value) => value / 0.0042; // 1 teaspoon of sugar = 0.0042 kilograms
    }
    public class OuncesToTeaspoonsOfSugar : IConversion
    {
        public int Id => 111;
        public string FromUnit => "ounces";
        public string ToUnit => "sugar";
        public double Convert(double value) => value / 0.15; // 1 teaspoon of sugar = 0.15 ounces
    }
    public class PoundsToTeaspoonsOfSugar : IConversion
    {
        public int Id => 112;
        public string FromUnit => "pounds";
        public string ToUnit => "sugar";
        public double Convert(double value) => value / 0.0093; // 1 teaspoon of sugar = 0.0093 pounds
    }

    // Flour Conversions
    // Cups
    public class GramsToCupsOfFlour : IConversion
    {
        public int Id => 201;
        public string FromUnit => "grams";
        public string ToUnit => "flour";
        public double Convert(double value) => value / 125; // 1 cup of flour = 125 grams
    }
    public class KilogramsToCupsOfFlour : IConversion
    {
        public int Id => 202;
        public string FromUnit => "kilograms";
        public string ToUnit => "flour";
        public double Convert(double value) => value / 0.125; // 1 cup of flour = 0.125 kilograms
    }
    public class OuncesToCupsOfFlour : IConversion
    {
        public int Id => 203;
        public string FromUnit => "ounces";
        public string ToUnit => "cups";
        public double Convert(double value) => value / 4.41; // 1 cup of flour = 4.41 ounces
    }
    public class PoundsToCupsOfFlour : IConversion
    {
        public int Id => 204;
        public string FromUnit => "pounds";
        public string ToUnit => "cups";
        public double Convert(double value) => value / 0.275; // 1 cup of flour = 0.275 pounds
    }

    // Tablespoone
    public class GramsToTablespoonsOfFlour : IConversion
    {
        public int Id => 210;
        public string FromUnit => "grams";
        public string ToUnit => "tablespoons";
        public double Convert(double value) => value * 0.066; // 1 gram of flour = 0.066 tablespoons
    }
    public class KilogramsToTablespoonsOfFlour : IConversion
    {
        public int Id => 211;
        public string FromUnit => "kilograms";
        public string ToUnit => "tablespoons";
        public double Convert(double value) => value * 66.0; // 1 kilogram of flour = 66 tablespoons
    }
    public class OuncesToTablespoonsOfFlour : IConversion
    {
        public int Id => 212;
        public string FromUnit => "ounces";
        public string ToUnit => "tablespoons";
        public double Convert(double value) => value * 1.905; // 1 ounce of flour = 1.905 tablespoons
    }
    public class PoundsToTablespoonsOfFlour : IConversion
    {
        public int Id => 213;
        public string FromUnit => "pounds";
        public string ToUnit => "tablespoons";
        public double Convert(double value) => value * 30.5; // 1 pound of flour = 30.5 tablespoons
    }

    // Teaspoon
    public class GramsToTeaspoonsOfFlour : IConversion
    {
        public int Id => 214;
        public string FromUnit => "grams";
        public string ToUnit => "teaspoons";
        public double Convert(double value) => value * 0.2; // 1 gram of flour = 0.2 teaspoons
    }
    public class KilogramsToTeaspoonsOfFlour : IConversion
    {
        public int Id => 215;
        public string FromUnit => "kilograms";
        public string ToUnit => "teaspoons";
        public double Convert(double value) => value * 200.0; // 1 kilogram of flour = 200 teaspoons
    }
    public class OuncesToTeaspoonsOfFlour : IConversion
    {
        public int Id => 216;
        public string FromUnit => "ounces";
        public string ToUnit => "teaspoons";
        public double Convert(double value) => value * 6.0; // 1 ounce of flour = 6 teaspoons
    }
    public class PoundsToTeaspoonsOfFlour : IConversion
    {
        public int Id => 217;
        public string FromUnit => "pounds";
        public string ToUnit => "teaspoons";
        public double Convert(double value) => value * 96.0; // 1 pound of flour = 96 teaspoons
    }


    // Water Conversions
    // Cups
    public class GramsToCupsOfWater : IConversion
    {
        public int Id => 301;
        public string FromUnit => "grams";
        public string ToUnit => "cups";
        public double Convert(double value) => value / 237; // 1 cup of water = 237 grams
    }
    public class KilogramsToCupsOfWater : IConversion
    {
        public int Id => 302;
        public string FromUnit => "kilograms";
        public string ToUnit => "cups";
        public double Convert(double value) => value / 0.237; // 1 cup of water = 0.237 kilograms
    }
    public class OuncesToCupsOfWater : IConversion
    {
        public int Id => 303;
        public string FromUnit => "ounces";
        public string ToUnit => "cups";
        public double Convert(double value) => value / 8.34; // 1 cup of water = 8.34 ounces
    }
    public class PoundsToCupsOfWater : IConversion
    {
        public int Id => 304;
        public string FromUnit => "pounds";
        public string ToUnit => "cups";
        public double Convert(double value) => value / 0.52; // 1 cup of water = 0.52 pounds
    }

    // tablespoon
    public class GramsToTablespoonsOfWater : IConversion
    {
        public int Id => 218;
        public string FromUnit => "grams";
        public string ToUnit => "tablespoons";
        public double Convert(double value) => value / 15.0; // 1 gram of water = 1/15 tablespoons
    }
    public class KilogramsToTablespoonsOfWater : IConversion
    {
        public int Id => 219;
        public string FromUnit => "kilograms";
        public string ToUnit => "tablespoons";
        public double Convert(double value) => value * 66.67; // 1 kilogram of water = 66.67 tablespoons
    }
    public class OuncesToTablespoonsOfWater : IConversion
    {
        public int Id => 220;
        public string FromUnit => "ounces";
        public string ToUnit => "tablespoons";
        public double Convert(double value) => value * 2.0; // 1 ounce of water = 2 tablespoons
    }
    public class PoundsToTablespoonsOfWater : IConversion
    {
        public int Id => 221;
        public string FromUnit => "pounds";
        public string ToUnit => "tablespoons";
        public double Convert(double value) => value * 32.0; // 1 pound of water = 32 tablespoons
    }

    // teaspoon
    public class GramsToTeaspoonsOfWater : IConversion
    {
        public int Id => 222;
        public string FromUnit => "grams";
        public string ToUnit => "teaspoons";
        public double Convert(double value) => value / 5.0; // 1 gram of water = 1/5 teaspoons
    }
    public class KilogramsToTeaspoonsOfWater : IConversion
    {
        public int Id => 223;
        public string FromUnit => "kilograms";
        public string ToUnit => "teaspoons";
        public double Convert(double value) => value * 200.0; // 1 kilogram of water = 200 teaspoons
    }
    public class OuncesToTeaspoonsOfWater : IConversion
    {
        public int Id => 224;
        public string FromUnit => "ounces";
        public string ToUnit => "teaspoons";
        public double Convert(double value) => value * 6.0; // 1 ounce of water = 6 teaspoons
    }
    public class PoundsToTeaspoonsOfWater : IConversion
    {
        public int Id => 225;
        public string FromUnit => "pounds";
        public string ToUnit => "teaspoons";
        public double Convert(double value) => value * 96.0; // 1 pound of water = 96 teaspoons
    }


    // Butter Conversions
    // Cups
    public class GramsToCupsOfButter : IConversion
    {
        public int Id => 401;
        public string FromUnit => "grams";
        public string ToUnit => "cups";
        public double Convert(double value) => value / 227; // 1 cup of butter = 227 grams
    }
    public class KilogramsToCupsOfButter : IConversion
    {
        public int Id => 402;
        public string FromUnit => "kilograms";
        public string ToUnit => "cups";
        public double Convert(double value) => value / 0.227; // 1 cup of butter = 0.227 kilograms
    }
    public class OuncesToCupsOfButter : IConversion
    {
        public int Id => 403;
        public string FromUnit => "ounces";
        public string ToUnit => "cups";
        public double Convert(double value) => value / 8; // 1 cup of butter = 8 ounces
    }
    public class PoundsToCupsOfButter : IConversion
    {
        public int Id => 404;
        public string FromUnit => "pounds";
        public string ToUnit => "cups";
        public double Convert(double value) => value / 0.5; // 1 cup of butter = 0.5 pounds
    }

    // Tablespoon
    public class GramsToTablespoonsOfButter : IConversion
    {
        public int Id => 301;
        public string FromUnit => "grams";
        public string ToUnit => "tablespoons";
        public double Convert(double value) => value / 14.2; // 1 gram of butter = 1/14.2 tablespoons
    }
    public class KilogramsToTablespoonsOfButter : IConversion
    {
        public int Id => 302;
        public string FromUnit => "kilograms";
        public string ToUnit => "tablespoons";
        public double Convert(double value) => value * 70.42; // 1 kilogram of butter = 70.42 tablespoons
    }
    public class OuncesToTablespoonsOfButter : IConversion
    {
        public int Id => 303;
        public string FromUnit => "ounces";
        public string ToUnit => "tablespoons";
        public double Convert(double value) => value * 2.0; // 1 ounce of butter = 2 tablespoons
    }
    public class PoundsToTablespoonsOfButter : IConversion
    {
        public int Id => 304;
        public string FromUnit => "pounds";
        public string ToUnit => "tablespoons";
        public double Convert(double value) => value * 32.0; // 1 pound of butter = 32 tablespoons
    }

    // Teaspoon
    public class GramsToTeaspoonsOfButter : IConversion
    {
        public int Id => 305;
        public string FromUnit => "grams";
        public string ToUnit => "teaspoons of butter";
        public double Convert(double value) => value / 4.75; // 1 gram of butter = 1/4.75 teaspoons
    }
    public class KilogramsToTeaspoonsOfButter : IConversion
    {
        public int Id => 306;
        public string FromUnit => "kilograms";
        public string ToUnit => "teaspoons of butter";
        public double Convert(double value) => value * 210.53; // 1 kilogram of butter = 210.53 teaspoons
    }
    public class OuncesToTeaspoonsOfButter : IConversion
    {
        public int Id => 307;
        public string FromUnit => "ounces";
        public string ToUnit => "teaspoons of butter";
        public double Convert(double value) => value * 6.0; // 1 ounce of butter = 6 teaspoons
    }
    public class PoundsToTeaspoonsOfButter : IConversion
    {
        public int Id => 308;
        public string FromUnit => "pounds";
        public string ToUnit => "teaspoons of butter";
        public double Convert(double value) => value * 96.0; // 1 pound of butter = 96 teaspoons
    }


    // Milk Conversions
    // Cups
    public class GramsToCupsOfMilk : IConversion
    {
        public int Id => 501;
        public string FromUnit => "grams";
        public string ToUnit => "cups";
        public double Convert(double value) => value / 240; // 1 cup of milk = 240 grams
    }
    public class KilogramsToCupsOfMilk : IConversion
    {
        public int Id => 502;
        public string FromUnit => "kilograms";
        public string ToUnit => "cups";
        public double Convert(double value) => value / 0.24; // 1 cup of milk = 0.24 kilograms
    }
    public class OuncesToCupsOfMilk : IConversion
    {
        public int Id => 503;
        public string FromUnit => "ounces";
        public string ToUnit => "cups";
        public double Convert(double value) => value / 8.11; // 1 cup of milk = 8.11 ounces
    }
    public class PoundsToCupsOfMilk : IConversion
    {
        public int Id => 504;
        public string FromUnit => "pounds";
        public string ToUnit => "cups";
        public double Convert(double value) => value / 0.528; // 1 cup of milk = 0.528 pounds
    }

    // Tablespoon
    public class GramsToTablespoonsOfMilk : IConversion
    {
        public int Id => 309;
        public string FromUnit => "grams";
        public string ToUnit => "tablespoons";
        public double Convert(double value) => value / 15.0; // 1 gram of milk = 1/15 tablespoons
    }
    public class KilogramsToTablespoonsOfMilk : IConversion
    {
        public int Id => 310;
        public string FromUnit => "kilograms";
        public string ToUnit => "tablespoons";
        public double Convert(double value) => value * 66.67; // 1 kilogram of milk = 66.67 tablespoons
    }
    public class OuncesToTablespoonsOfMilk : IConversion
    {
        public int Id => 311;
        public string FromUnit => "ounces";
        public string ToUnit => "tablespoons";
        public double Convert(double value) => value * 2.0; // 1 ounce of milk = 2 tablespoons
    }
    public class PoundsToTablespoonsOfMilk : IConversion
    {
        public int Id => 312;
        public string FromUnit => "pounds";
        public string ToUnit => "tablespoons";
        public double Convert(double value) => value * 32.0; // 1 pound of milk = 32 tablespoons
    }

    // Teaspon
    public class GramsToTeaspoonsOfMilk : IConversion
    {
        public int Id => 313;
        public string FromUnit => "grams";
        public string ToUnit => "teaspoons of milk";
        public double Convert(double value) => value / 5.0; // 1 gram of milk = 1/5 teaspoons
    }
    public class KilogramsToTeaspoonsOfMilk : IConversion
    {
        public int Id => 314;
        public string FromUnit => "kilograms";
        public string ToUnit => "teaspoons of milk";
        public double Convert(double value) => value * 200.0; // 1 kilogram of milk = 200 teaspoons
    }
    public class OuncesToTeaspoonsOfMilk : IConversion
    {
        public int Id => 315;
        public string FromUnit => "ounces";
        public string ToUnit => "teaspoons of milk";
        public double Convert(double value) => value * 6.0; // 1 ounce of milk = 6 teaspoons
    }
    public class PoundsToTeaspoonsOfMilk : IConversion
    {
        public int Id => 316;
        public string FromUnit => "pounds";
        public string ToUnit => "teaspoons of milk";
        public double Convert(double value) => value * 96.0; // 1 pound of milk = 96 teaspoons
    }


    // Rice Conversions
    // Cups
    public class GramsToCupsOfRice : IConversion
    {
        public int Id => 601;
        public string FromUnit => "grams";
        public string ToUnit => "cups";
        public double Convert(double value) => value / 185; // 1 cup of rice = 185 grams
    }
    public class KilogramsToCupsOfRice : IConversion
    {
        public int Id => 602;
        public string FromUnit => "kilograms";
        public string ToUnit => "cups";
        public double Convert(double value) => value / 0.185; // 1 cup of rice = 0.185 kilograms
    }
    public class OuncesToCupsOfRice : IConversion
    {
        public int Id => 603;
        public string FromUnit => "ounces";
        public string ToUnit => "cups";
        public double Convert(double value) => value / 6.53; // 1 cup of rice = 6.53 ounces
    }
    public class PoundsToCupsOfRice : IConversion
    {
        public int Id => 604;
        public string FromUnit => "pounds";
        public string ToUnit => "cups";
        public double Convert(double value) => value / 0.41; // 1 cup of rice = 0.41 pounds
    }

    // Tablespoon
    public class GramsToTablespoonsOfRice : IConversion
    {
        public int Id => 317;
        public string FromUnit => "grams";
        public string ToUnit => "tablespoons";
        public double Convert(double value) => value / 15.0; // 1 gram of rice = 1/15 tablespoons
    }
    public class KilogramsToTablespoonsOfRice : IConversion
    {
        public int Id => 318;
        public string FromUnit => "kilograms";
        public string ToUnit => "tablespoons";
        public double Convert(double value) => value * 66.67; // 1 kilogram of rice = 66.67 tablespoons
    }
    public class OuncesToTablespoonsOfRice : IConversion
    {
        public int Id => 319;
        public string FromUnit => "ounces";
        public string ToUnit => "tablespoons";
        public double Convert(double value) => value * 2.0; // 1 ounce of rice = 2 tablespoons
    }
    public class PoundsToTablespoonsOfRice : IConversion
    {
        public int Id => 320;
        public string FromUnit => "pounds";
        public string ToUnit => "tablespoons";
        public double Convert(double value) => value * 32.0; // 1 pound of rice = 32 tablespoons
    }
    // Teaspone
    public class GramsToTeaspoonsOfRice : IConversion
    {
        public int Id => 321;
        public string FromUnit => "grams";
        public string ToUnit => "teaspoons";
        public double Convert(double value) => value / 5.0; // 1 gram of rice = 1/5 teaspoons
    }
    public class KilogramsToTeaspoonsOfRice : IConversion
    {
        public int Id => 322;
        public string FromUnit => "kilograms";
        public string ToUnit => "teaspoons";
        public double Convert(double value) => value * 200.0; // 1 kilogram of rice = 200 teaspoons
    }
    public class OuncesToTeaspoonsOfRice : IConversion
    {
        public int Id => 323;
        public string FromUnit => "ounces";
        public string ToUnit => "teaspoons";
        public double Convert(double value) => value * 6.0; // 1 ounce of rice = 6 teaspoons
    }
    public class PoundsToTeaspoonsOfRice : IConversion
    {
        public int Id => 324;
        public string FromUnit => "pounds";
        public string ToUnit => "teaspoons";
        public double Convert(double value) => value * 96.0; // 1 pound of rice = 96 teaspoons
    }

}

