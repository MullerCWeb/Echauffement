using System.Globalization; // À ajouter si l'on a des problème sur la conversion des float 

namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */
        
        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré
        Console.WriteLine("Bonjour. Je m'appelle Cédric et mon jeu préféré est Minecraft");
        
        // Etape 2 : demandez à l'utilisateur son prénom et son âge
        Console.WriteLine("Et toi, comment t'appelles-tu ?");
        string firstName = Console.ReadLine();
        
        Console.WriteLine("Tu as quel âge ?");
        int age = Convert.ToInt32(Console.ReadLine());
        bool isUnderage = true;

        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur
        if (age >= 18)
        {
            Console.WriteLine("Tu es majeur");
            isUnderage = true;
        }
        else
        {
            Console.WriteLine("Tu es mineur");
        }

        // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre décimal)
        Console.WriteLine("Combien d'euros as-tu ?");
        float money = Convert.ToSingle(Console.ReadLine());

        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix
        Console.WriteLine("\n=== Choix d'armes ===");
        Console.WriteLine("1. Dynamite : $1.00");
        Console.WriteLine("2. Machette : $10.00");
        Console.WriteLine("3. Revolver Cattleman : $50.00");
        Console.WriteLine("4. Carabine Lancaster : $135.00\n");

        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4
        Console.WriteLine("Quelle arme souhaites-tu acheter ? (1/2/3/4)");
        int weaponChoice = Convert.ToInt32(Console.ReadLine());

        // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4
        if (weaponChoice == 1)
        {
            float price = 1.0f;
            if (money < price || isUnderage) // Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent
            {
                // Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible
                Console.WriteLine("Tu ne peux pas acheter cette arme");
            }
            else
            {
                // Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée
                money -= price;
                Console.WriteLine("Félicitation, tu as acheté une dynamite");
            }
        }
        else if (weaponChoice == 2)
        {
            float price = 10.0f;
            if (money < price || isUnderage)
            {
                Console.WriteLine("Tu ne peux pas acheter cette arme");
            }
            else
            {
                money -= price;
                Console.WriteLine("Félicitation, tu as acheté une dynamite");
            }
        }
        else if (weaponChoice == 3)
        {
            float price = 50.0f;
            if (money < price || isUnderage)
            {
                Console.WriteLine("Tu ne peux pas acheter cette arme");
            }
            else
            {
                money -= price;
                Console.WriteLine("Félicitation, tu as acheté une dynamite");
            }
        }
        else if (weaponChoice == 4)
        {
            float price = 135.0f;
            if (money < price || isUnderage)
            {
                Console.WriteLine("Tu ne peux pas acheter cette arme");
            }
            else
            {
                money -= price;
                Console.WriteLine("Félicitation, tu as acheté une dynamite");
            }
        }
        else
        {
            Console.WriteLine("Ton choix ne fait pas partie des options disponibles");
        }

        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}