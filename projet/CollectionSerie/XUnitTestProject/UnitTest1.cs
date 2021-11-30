using System;
using Xunit;
using Modele;
using System.Collections.Generic;
using Data;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Manager manager = new Manager(new Stub());
            Assert.DoesNotContain("One Piece",manager.Serietheque.ListeSeriesAffiche[0].Nom);
            Assert.DoesNotContain("C'est l'histoire de la vie", manager.Serietheque.ListeSeriesAffiche[0].Synopsis);
           
            

            Commentaire c = new Commentaire("J'adore cette série, les acteurs ont vraiment un talent incroyable");
            Commentaire c1 = new Commentaire("J'adore cette série, les agngnfggfgncteurs ont vraiment un talent incroyable");
            Commentaire c2 = new Commentaire("J'adore cette série, les acteurs ont vraiment unfnfnfnfng talent incroyable");

            Assert.Equal("J'adore cette série, les acteurs ont vraiment un talent incroyable", c.Avis);

            manager.Serietheque.ListeSeriesAffiche[0].AjouterCommentaire(c);
            manager.Serietheque.ListeSeriesAffiche[0].AjouterCommentaire(c1);
            manager.Serietheque.ListeSeriesAffiche[0].AjouterCommentaire(c2);

            
            Inscrit ins1 = new Inscrit("azerty", "toto123");
            Inscrit ins2 = new Inscrit("aserty", "toto321");
            Inscrit ins3 = ins1;
            Inscrit ins4 = new Inscrit(null, "toto");

            Console.WriteLine(manager.Inscription(ins1));

            Assert.Equal("toto123", ins1.MotDePasse);
            Assert.NotEqual("titi123", ins1.MotDePasse);

            Assert.NotSame(ins1, ins2);
            Assert.Same(ins1, ins3);

            Assert.Null(ins4.Identifiant);

            manager.Inscription(ins2);

            Assert.Same(manager.Connexion(ins1.Identifiant,ins1.MotDePasse), manager.Connexion(ins2.Identifiant,ins2.MotDePasse));

            Assert.NotSame(manager.Inscription(ins4), manager.Inscription(ins3)); 
        }
    }
}
