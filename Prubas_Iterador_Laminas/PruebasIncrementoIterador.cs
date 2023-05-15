using System;
using Logica_Iterador;
using Poo_PS_GoF_Iterator;

namespace PruebasIncrementoIterador
{
    [TestClass]
    public class PruebasIncrementoIterador
    {
        [TestMethod]
        public void ValidarIncremento3()
        {
            // Arrange

            Album miAlbumPrueba = new Album();
            miAlbumPrueba[0] = new Lamina(1, "Equipo - Francia");
            miAlbumPrueba[1] = new Lamina(2, "Jugador - Lionel Messi");
            miAlbumPrueba[2] = new Lamina(3, "Equipo - Brasil");
            miAlbumPrueba[3] = new Lamina(4, "Jugador - Cristiano Ronaldo");

            Iterador iteradorPrueba = miAlbumPrueba.CrearIterador();
            iteradorPrueba.Incremento = 3;

            // Act

            Lamina laminaObtenida = iteradorPrueba.Siguiente();
            
            // Assert

            Lamina laminaEsperada = miAlbumPrueba[iteradorPrueba.Incremento];
            Assert.AreEqual(laminaEsperada, laminaObtenida);
        }

        [TestMethod]
        public void ValidarIncremento4()
        {
            // Arrange

            Album miAlbumPrueba = new Album();
            miAlbumPrueba[0] = new Lamina(1, "Equipo - Francia");
            miAlbumPrueba[1] = new Lamina(2, "Jugador - Lionel Messi");
            miAlbumPrueba[2] = new Lamina(3, "Equipo - Brasil");
            miAlbumPrueba[3] = new Lamina(4, "Jugador - Cristiano Ronaldo");
            miAlbumPrueba[4] = new Lamina(5, "Equipo - Inglaterra");

            Iterador iteradorPrueba = miAlbumPrueba.CrearIterador();
            iteradorPrueba.Incremento = 4;

            // Act

            Lamina laminaObtenida = iteradorPrueba.Siguiente();

            // Assert

            Lamina laminaEsperada = miAlbumPrueba[iteradorPrueba.Incremento];
            Assert.AreEqual(laminaEsperada, laminaObtenida);
        }

        [TestMethod]
        public void ValidarIncremento6()
        {
            // Arrange

            Album miAlbumPrueba = new Album();
            miAlbumPrueba[0] = new Lamina(1, "Equipo - Francia");
            miAlbumPrueba[1] = new Lamina(2, "Jugador - Lionel Messi");
            miAlbumPrueba[2] = new Lamina(3, "Equipo - Brasil");
            miAlbumPrueba[3] = new Lamina(4, "Jugador - Cristiano Ronaldo");
            miAlbumPrueba[4] = new Lamina(5, "Equipo - Inglaterra");
            miAlbumPrueba[5] = new Lamina(6, "Equipo - Japón");
            miAlbumPrueba[6] = new Lamina(7, "Jugador - Neymar");

            Iterador iteradorPrueba = miAlbumPrueba.CrearIterador();
            iteradorPrueba.Incremento = 6;

            // Act

            Lamina laminaObtenida = iteradorPrueba.Siguiente();

            // Assert

            Lamina laminaEsperada = miAlbumPrueba[iteradorPrueba.Incremento];
            Assert.AreEqual(laminaEsperada, laminaObtenida);
        }
    }
}