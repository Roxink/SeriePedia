using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using Modele;

namespace Data
{
    public class Stub : IPersistance
    {
        public Stub()
        {
        }

        public ComptesUtilisateur ChargerDonneesComptesUtilisateur()
        {
            return new ComptesUtilisateur();
        }

        public Serietheque ChargerDonneesSerietheque()
        {
            Serietheque serietheque = new Serietheque();

            Serie s = new Serie("SF et Action", "A Hawkins, en 1983 dans l'Indiana.Lorsque Will Byers disparaît de son domicile, ses amis se lancent dans une recherche semée d’embûches pour le retrouver. Dans leur quête de réponses, les garçons rencontrent une étrange jeune fille en fuite. Les garçons se lient d'amitié avec la demoiselle tatouée du chiffre 11 sur son poignet et au crâne rasé et découvrent petit à petit les détails sur son inquiétante situation. Elle est peut-être la clé de tous les mystères qui se cachent dans cette petite ville en apparence tranquille…", new Uri(@"../../../../Video-BandeAnnonce/SF_et_Action/stranger_things.mp4", UriKind.Relative), "/Images;Component/SF_et_Action/stranger_things.jpg", "Stranger Things", "Netflix");
            s.AjouterCommentaire(new Commentaire("Cette série est incroyable!!!"));
            serietheque.ListeSeries.Add(s);
             serietheque.ListeSeries.Add(new Serie("SF et Action", "Takeshi Kovacs est un ancien soldat et seul survivant d’un groupe de guerriers d'élite vaincus lors d’un soulèvement contre le nouvel ordre mondial. Son esprit est emprisonné dans la glace pendant des siècles, jusqu’à ce que Laurens Bancroft, un homme extrêmement riche et vivant depuis plusieurs siècles lui offre la chance de vivre à nouveau. En échange, Kovacs doit résoudre un meurtre ... celui de Bancroft lui-même.Adapté du roman de Richard Morgan.", new Uri(@"../../../../Video-BandeAnnonce/SF_et_Action/altered_carbon.mp4", UriKind.Relative), "/Images;Component/SF_et_Action/altered_carbon.jpg", "Altered Carbon", "Netflix"));
             serietheque.ListeSeries.Add(new Serie("SF et Action", "En 1989, le même jour, quarante-trois bébés sont inexplicablement nés de femmes qui n'étaient pas enceintes et que rien ne relie. Sir Reginald Hargreeves, un industriel milliardaire, adopte sept de ces enfants et crée The Umbrella Academy pour les préparer à sauver le monde. Mais tout ne se déroule pas comme prévu. Les enfants devenus adolescents, la famille se désagrège et l'équipe est dispersée. Les six membres toujours en vie, désormais trentenaires, se retrouvent à l'occasion de la mort de Hargreeves. Luther, Diego, Allison, Klaus, Vanya et Numéro Cinq travaillent ensemble pour résoudre le mystère qui entoure la mort de leur père. La famille désunie se sépare cependant de nouveau, incapable de gérer des personnalités et des pouvoirs trop différents, sans même parler de l'apocalypse qui menace...", new Uri(@"../../../../Video-BandeAnnonce/SF_et_Action/umbrella-academy.mp4", UriKind.Relative), "/Images;Component/SF_et_Action/the_umbrella_academy.jpg", "Umbrella Academy", "Netflix"));
             serietheque.ListeSeries.Add(new Serie("SF et Action", "Après un siècle de silence, les klingons refont surface. Déterminés à réunifier leur empire, ils déclarent la guerre à la Fédération des planètes unies. Officier en disgrâce de la Starfleet, Michael Burnham se retrouve au centre du conflit.", new Uri(@"../../../../Video-BandeAnnonce/SF_et_Action/star_trek_discovery.mp4", UriKind.Relative), "/Images;Component/SF_et_Action/star_trek_discovery.jpg", "Star Trek : Discovery", "Netflix"));
             serietheque.ListeSeries.Add(new Serie("SF et Action", "Après une apocalypse nucléaire causée par l'Homme lors d'une troisième Guerre Mondiale, les 318 survivants recensés se réfugient dans des stations spatiales et parviennent à y vivre et à se reproduire, atteignant le nombre de 4000. Mais 97 ans plus tard, le vaisseau mère, l'Arche, est en piteux état. Une centaine de jeunes délinquants emprisonnés au fil des années pour des crimes ou des trahisons sont choisis comme cobayes par les autorités pour redescendre sur Terre et tester les chances de survie. Dès leur arrivée, ils découvrent un nouveau monde dangereux mais fascinant...", new Uri(@"../../../../Video-BandeAnnonce/SF_et_Action/the_100.mp4", UriKind.Relative), "/Images;Component/SF_et_Action/the_100.jpg", "The 100", "Netflix, Canal VOD"));

             serietheque.ListeSeries.Add(new Serie("Sitcom", "Les péripéties de 6 jeunes newyorkais liés par une profonde amitié. Entre amour, travail, famille, ils partagent leurs bonheurs et leurs soucis au Central Perk, leur café favori...", new Uri(@"../../../../Video-BandeAnnonce/Sitcom/friends.mp4", UriKind.Relative), "/Images;Component/Sitcom/friends.jpg", "Friends", "Netflix, Canal VOD"));
             serietheque.ListeSeries.Add(new Serie("Sitcom", "Petit génie malgré lui, Malcolm vit dans une famille hors du commun. Le jeune surdoué n'hésite pas à se servir de son intelligence pour faire les 400 coups avec ses frères. Et les parents tentent tant bien que mal de canaliser l'énergie de ces petits démons.", new Uri(@"../../../../Video-BandeAnnonce/Sitcom/malcolm.mp4", UriKind.Relative), "/Images;Component/Sitcom/malcolm.jpg", "Malcom", "Amazon Prime, Canal VOD"));
             serietheque.ListeSeries.Add(new Serie("Sitcom", "Leonard et Sheldon pourraient vous dire tout ce que vous voudriez savoir à propos de la physique quantique. Mais ils seraient bien incapables de vous expliquer quoi que ce soit sur la vie réelle, le quotidien ou les relations humaines... Mais tout va changer avec l'arrivée de la superbe Penny, leur voisine. Ce petit bout de femme, actrice à ses heures et serveuse pour le beurre, va devenir leur professeur de vie ! ", new Uri(@"../../../../Video-BandeAnnonce/Sitcom/the_big_bang_theorie.mp4", UriKind.Relative), "/Images;Component/Sitcom/the_big_bang_theory.jpg", "The Big Bang Théorie", "Amazon Prime, Netflix, Salto"));
             serietheque.ListeSeries.Add(new Serie("Sitcom", "Ted se remémore ses jeunes années, lorsqu'il était encore célibataire. Il raconte à ses enfants avec nostalgie ses moments d'égarements et de troubles, ses rencontres et ses recherches effrénées du Grand Amour et les facéties de sa bande d'amis...", new Uri(@"../../../../Video-BandeAnnonce/Sitcom/how_i_met_your_mother.mp4", UriKind.Relative), "/Images;Component/Sitcom/how_i_met_your_mother.jpg", "How I met your mother", "Amazon Prime, Netflix, Disney+"));
             serietheque.ListeSeries.Add(new Serie("Sitcom", "Fils aîné d’une famille de classe moyenne et martyrisé par sa petite soeur, la démoniaque Ève, Adam, lycéen de 18 ans, est comme la majorité des ados, un glandeur professionnel dont le principal passe-temps est de se laisser vivre. Grande gueule et frimeur devant ses potes et sa famille, il l’est beaucoup moins devant Jenna, la bombe du lycée avec laquelle il veut sortir… Face à ses angoisses et ses rêves d’ado, il doit affronter son plus grand défi : le monde des adultes… et les meufs !", new Uri(@"../../../../Video-BandeAnnonce/Sitcom/soda.mp4", UriKind.Relative), "/Images;Component/Sitcom/soda.jpg", "Soda", "Salto"));

             serietheque.ListeSeries.Add(new Serie("Manga", "Dans un monde ravagé par des titans mangeurs d’homme depuis plus d’un siècle, les rares survivants de l’Humanité n’ont d’autre choix pour survivre que de se barricader dans une cité-forteresse. Le jeune Eren, témoin de la mort de sa mère dévorée par un titan, n’a qu’un rêve : entrer dans le corps d’élite chargé de découvrir l’origine des Titans et les annihiler jusqu’au dernier…", new Uri(@"../../../../Video-BandeAnnonce/Manga/l_attaque_des_titans.mp4", UriKind.Relative), "/Images;Component/Manga/l_attaque_des_titans.jpg", "L’Attaque des Titans", "ADN, Amazon Prime, Netflix"));
             serietheque.ListeSeries.Add(new Serie("Manga", "Cinq ans après le mariage de Son Gokû, Raditz, un mystérieux guerrier de l'espace, arrive sur Terre. Il apprend à Son Gôku qu'il ne reste plus que quatre survivant sur leur planète et que ce dernier avait été envoyé sur terre pour la détruire...", new Uri(@"../../../../Video-BandeAnnonce/Manga/dragon_ball_z.mp4", UriKind.Relative), "/Images;Component/Manga/dragon_ball_z.jpg", "Dragon Ball Z", "Salto"));
             serietheque.ListeSeries.Add(new Serie("Manga", "Dans le village de Konoha vit Naruto, un jeune garçon détesté et craint des villageois, du fait qu'il détient en lui Kyuubi (démon renard à neuf queues) d'une incroyable force, qui a tué un grand nombre de personnes. Le ninja le plus puissant de Konoha à l'époque, Minato Namikaze, a réussi à sceller ce démon dans le corps de Naruto. C'est ainsi que douze ans plus tard, Naruto rêve de devenir le plus grand Hokage de Konoha afin que tous le reconnaissent à sa juste valeur. Mais la route pour devenir Hokage est très longue.", new Uri(@"../../../../Video-BandeAnnonce/Manga/naruto.mp4", UriKind.Relative), "/Images;Component/Manga/naruto.jpg", "Naruto", "ADN, Amazon Prime, Netflix"));
             serietheque.ListeSeries.Add(new Serie("Manga", "Dans un monde magique au beau milieu du pays de Fiore, la jeune Lucy Heartfiria rejoint la Guilde Magique de Fairy Tail. L'attendent de nombreuses et palpitantes aventures aux côtés de Natsu Dragnir, Happy, Erza Scarlett et Grey Fullbuster.", new Uri(@"../../../../Video-BandeAnnonce/Manga/fairytail-official-trailer.mp4", UriKind.Relative), "/Images;Component/Manga/fairy_tail.jpg", "Fairy Tail", "ADN, Netflix"));
             serietheque.ListeSeries.Add(new Serie("Manga", "En 2022, l'humanité a réussi à créer une réalité virtuelle. Grâce à un casque, les humains peuvent se plonger entièrement dans le monde virtuel en étant comme déconnectés de la réalité, et Sword Art Online est le premier MMORPG a utiliser ce système. Mais voila que le premier jour de jeu, 10 000 personnes se retrouvent piégées dans cette réalité virtuelle par son créateur : Akihiko Kayaba. Le seul moyen d'en sortir est de finir le jeu. Mais ce ne sera pas facile de sortir de ce monde virtuel puisque si un joueur perd la partie, il meurt également dans la vraie vie. Kirito décide alors de partir à la conquête du jeu en solo, avec pour avantage le fait de faire partie des 1 000 ex-bêta-testeurs.", new Uri(@"../../../../Video-BandeAnnonce/Manga/sword_art_online.mp4", UriKind.Relative), "/Images;Component/Manga/sword_art_online.jpg", "Sword Art Online", "Netflix"));

             serietheque.ListeSeries.Add(new Serie("Animé", "Un brillant inventeur et son petit-fils un peu à l'Ouest partent à l'aventure...", new Uri(@"../../../../Video-BandeAnnonce/Anime/rick_et_morty.mp4", UriKind.Relative), "/Images;Component/Anime/rick_et_morty.jpg", "Rick et Morty", "Netflix"));
             serietheque.ListeSeries.Add(new Serie("Animé", "Les Simpson, famille américaine moyenne, vivent à Springfield. Homer, le père, a deux passions : regarder la télé et boire des bières. Mais son quotidien est rarement reposant, entre son fils Bart qui fait toutes les bêtises possibles, sa fille Lisa qui est une surdouée, ou encore sa femme Marge qui ne supporte pas de le voir se soûler à longueur de journée.", new Uri(@"../../../../Video-BandeAnnonce/Anime/les_simpsons.mp4", UriKind.Relative), "/Images;Component/Anime/les_simpsons.jpg", "Les Simpson", "Disney+"));
             serietheque.ListeSeries.Add(new Serie("Animé", "Direction le royaume médiéval en ruines de Dreamland pour suivre les mésaventures de Bean, une jeune princesse picoleuse, de son compagnon, un elfe chicaneur nommé Elfo et de son propre démon, Luci. En chemin, le fantasque trio rencontrera des ogres, des lutins, des harpies, des diablotins, des trolls, des morses et beaucoup d’humains idiots.", new Uri(@"../../../../Video-BandeAnnonce/Anime/desenchantee.mp4", UriKind.Relative), "/Images;Component/Anime/desenchantee.jpg", "Désenchantée", "Netflix"));
             serietheque.ListeSeries.Add(new Serie("Animé", "Accidentellement cryogénisé le 31 décembre 1999 alors qu'il livrait une pizza, Fry se réveille 1000 plus tard à New York. A l'aube de l'an 3000, le monde a bien changé, peuplé de robots et d'extrarrestres. Le jeune homme retrouve l'un de ses descendants qui l'engage lui et ses nouveaux amis, Leela et Bender, au Planet Express, une entreprise de livraison. Ensemble, ils vont devoir faire face à de périlleuses et délirantes missions dans un monde des plus surprenants.", new Uri(@"../../../../Video-BandeAnnonce/Anime/futurama.mp4", UriKind.Relative), "/Images;Component/Anime/futurama.jpg", "Futurama", "Disney+"));
             serietheque.ListeSeries.Add(new Serie("Animé", "La petite ville de South Park dans le Colorado est le théâtre des aventures de Cartman, Stan, Kyle et Kenny, quatre enfants qui ont un langage un peu... décalé !", new Uri(@"../../../../Video-BandeAnnonce/Anime/south-park.mp4", UriKind.Relative), "/Images;Component/Anime/south_park.jpg", "South Park", "Amazon Prime, Netflix"));

             serietheque.ListeSeries.Add(new Serie("Thriller", "Huit voleurs font une prise d'otages dans la Maison royale de la Monnaie d'Espagne, tandis qu'un génie du crime manipule la police pour mettre son plan à exécution.", new Uri(@"../../../../Video-BandeAnnonce/Thriller/la-casa-de-papel.mp4", UriKind.Relative), "/Images;Component/Thriller/la_casa_de_papel.png", "La Casa de Papel", "Netflix"));
             serietheque.ListeSeries.Add(new Serie("Thriller", "Walter White, 50 ans, est professeur de chimie dans un lycée du Nouveau-Mexique. Pour subvenir aux besoins de Skyler, sa femme enceinte, et de Walt Junior, son fils handicapé, il est obligé de travailler doublement. Son quotidien déjà morose devient carrément noir lorsqu'il apprend qu'il est atteint d'un incurable cancer des poumons. Les médecins ne lui donnent pas plus de deux ans à vivre. Pour réunir rapidement beaucoup d'argent afin de mettre sa famille à l'abri, Walter ne voit plus qu'une solution : mettre ses connaissances en chimie à profit pour fabriquer et vendre du crystal meth, une drogue de synthèse qui rapporte beaucoup. Il propose à Jesse, un de ses anciens élèves devenu un petit dealer de seconde zone, de faire équipe avec lui. Le duo improvisé met en place un labo itinérant dans un vieux camping-car. Cette association inattendue va les entraîner dans une série de péripéties tant comiques que pathétiques.", new Uri(@"../../../../Video-BandeAnnonce/Thriller/breaking-bad.mp4", UriKind.Relative), "/Images;Component/Thriller/breaking_bad.jpg", "Breaking Bad", "Netflix"));
             serietheque.ListeSeries.Add(new Serie("Thriller", "Chaque épisode de cette anthologie montre la dépendance des hommes vis-à-vis de tout ce qui a un écran...", new Uri(@"../../../../Video-BandeAnnonce/Thriller/black-mirror.mp4", UriKind.Relative), "/Images;Component/Thriller/black_mirror.jpg", "Black Mirror", "Netflix"));
             serietheque.ListeSeries.Add(new Serie("Thriller", "Loin d’un simple biopic de Pablo Escobar, Narcos retrace la lutte acharnée des États-Unis et de la Colombie contre le cartel de la drogue de Medellín, l’organisation la plus lucrative et impitoyable de l’histoire criminelle moderne. En multipliant les points de vue — policier, politique, judiciaire et personnel — la série dépeint l’essor du trafic de cocaïne et le bras de fer sanglant engagé avec les narcotrafiquants qui contrôlent le marché avec violence et ingéniosité.", new Uri(@"../../../../Video-BandeAnnonce/Thriller/narcos.mp4", UriKind.Relative), "/Images;Component/Thriller/narcos.jpg", "Narcos", "Disney+, Netflix"));
             serietheque.ListeSeries.Add(new Serie("Thriller", "Frank Underwood, homme politique rusé et vieux briscard de Washington, est prêt à tout pour conquérir le poste suprême...", new Uri(@"../../../../Video-BandeAnnonce/Thriller/house-of-cards.mp4", UriKind.Relative), "/Images;Component/Thriller/house_of_cards.png", "House of Cards", "Netflix"));

             serietheque.ListeSeries.Add(new Serie("Documentaire", "Pilotes, directeurs ou propriétaires d’écuries… Qu’ils soient sur le circuit ou dans le paddock, ils sont prêts à tout et vivent la saison de Formule 1 à 300 à l’heure.", new Uri(@"../../../../Video-BandeAnnonce/Documentaire/formule1.mp4", UriKind.Relative), "/Images;Component/Documentaire/Formula1.png", "Formula 1", "Netflix"));
             serietheque.ListeSeries.Add(new Serie("Documentaire", "A travers des images d'archives inédites, cette série documentaire en dix épisodes suit de l'intérieur la saison 1997-1998 des Chicago Bulls en route vers leur sixième titre en huit ans, et propose un portrait sportif et intime de Michael Jordan.", new Uri(@"../../../../Video-BandeAnnonce/Documentaire/the-last-dance.mp4", UriKind.Relative), "/Images;Component/Documentaire/The-Last-Dance.png", "The Last Dance", "Netflix"));
             serietheque.ListeSeries.Add(new Serie("Documentaire", "L'émission relate les aventures de l'animateur et présentateur Bear Grylls volontairement placé dans un environnement sauvage. Son but premier est de retrouver la civilisation dans un délai de dix jours en faisant appel aux techniques de survie en milieu hostile.", new Uri(@"../../../../Video-BandeAnnonce/Documentaire/man-vs-wild.mp4", UriKind.Relative), "/Images;Component/Documentaire/ManvsWild.png", "Man Vs. Wild", "Canal VOD"));
             serietheque.ListeSeries.Add(new Serie("Documentaire", "Dans des paysages aussi hostiles que majestueux, En pleine nature avec Bear Grylls entraîne les spectateurs dans le monde entier, des falaises de Sardaigne aux glaciers islandais en passant par les jungles inextricables des îles reculées du Panama ou encore les déserts et canyons de l’Utah. Accompagné dans chaque épisode par une célébrité, cette saison nous permet de découvrir entre autres les capacités de survie de Brie Larson, Clara Delevingne ou encore Channing Tatum. Celles-ci doivent dépasser leurs limites afin de découvrir si elles sont capables d’endurer la brutalité de la vie sauvage lors de voyages riches en action et frissons. Au cours de leur périple à travers certaines des régions sauvages les plus impitoyables au monde, les partenaires d’écran de Bear Grylls affrontent leurs peurs les plus viscérales et relèvent de nombreux défis, que ce soit pour faire face aux animaux sauvages ou descendre en rappel le long d’abruptes parois.Une fois engagés dans la nature sauvage, ils comptent sur leur instinct de survie, utilisent des techniques artisanales et font preuve de courage tout au long de leurs aventures pour survivre.", new Uri(@"../../../../Video-BandeAnnonce/Documentaire/En-plein-nature.mp4", UriKind.Relative), "/Images;Component/Documentaire/En-pleine-nature.png", "En pleine nature", "Disney+"));
             serietheque.ListeSeries.Add(new Serie("Documentaire", "Cette série documentaire suit les traces des pirates des Caraïbes qui s'emparèrent violemment des richesses du monde tout en créant une république étonnamment égalitaire.", new Uri(@"../../../../Video-BandeAnnonce/Documentaire/dans-le-sillage-des-pirates.mp4", UriKind.Relative), "/Images;Component/Documentaire/Dans-le-sillage-des-pirates.png", "Dans le sillage des pirates", "Netflix"));
            
            
            return serietheque;
        }

      /*   public void SauvegardeDonneesComptesUtilisateur(ComptesUtilisateur comptesUtilisateur)
         {
             Debug.WriteLine("Données enregistré");
         }

         public void SauvegardeDonneesSerietheque(Serietheque serietheque)
         {
             Debug.WriteLine("Données enregistré");
         }
        */
        public string FilePath { get; private set; } = "..//..//..//Données//XML";
        public string FileNameS { get; private set; } = "seriethequeDonnées.xml";

        public string FileNameC { get; private set; } = "comptesUtilisateurDonnées.xml";

        public void SauvegardeDonneesSerietheque(Serietheque serietheque)
        {
            var Serializer = new DataContractSerializer(typeof(Serietheque)); // on crée un Serializer du type de Seritheque 
            if (!Directory.Exists(FilePath)) // on vérifie que le répertoire /XML existe 
            {
                Directory.CreateDirectory(FilePath); // on crée le répertoire si besoin 
            }
            using (Stream s = File.Create(Path.Combine(FilePath, FileNameS))) // on instancie un Stream s sur le fichier seriethequeDonnées.xml
            {
                Serializer.WriteObject(s, serietheque); // on écrit dans le fichier seriethequeDonnées.xml les attributs qui sont DataMember de Serietheque
            }
        }

        public void SauvegardeDonneesComptesUtilisateur(ComptesUtilisateur comptesUtilisateur)
        {
            var Serializer = new DataContractSerializer(typeof(ComptesUtilisateur)); // on crée un Serializer du type de ComptesUtilisateur
            if (!Directory.Exists(FilePath)) // on vérifie que le répertoire /XML existe
            {
                Directory.CreateDirectory(FilePath); // on crée le répertoire si besoin
            }
            using (Stream s = File.Create(Path.Combine(FilePath, FileNameC))) // on instancie un Stream s sur le fichier comptesUtilisateurDonnées.xml
            {
                Serializer.WriteObject(s, comptesUtilisateur); //on écrit dans le fichier comptesUtilisateurDonnées.xml les attributs qui sont DataMember de CompteUtilisateur
            }

        }
    }
}
