namespace El_juguete_de_Elon
{
    public class ElJugueteDeElonTests
    {
        [Fact]
        public void Buy_new_car_returns_instance()
        {
            var car = RemoteControlCar.Comprar();
            Assert.NotNull(car);
        }

        [Fact]
        public void Buy_new_car_returns_new_car_each_time()
        {
            var car1 = RemoteControlCar.Comprar();
            var car2 = RemoteControlCar.Comprar();
            Assert.NotSame(car2, car1);
        }

        [Fact]
        public void New_car_distance_display()
        {
            var car = new RemoteControlCar();
            Assert.Equal("Distancia conducida: 0 metros", car.MostrarDistancia());
        }

        [Fact]
        public void New_car_battery_display()
        {
            var car = new RemoteControlCar();
            Assert.Equal("Batería al 100%", car.MostrarBateria());
        }

        [Fact]
        public void Distance_display_after_driving_once()
        {
            var car = new RemoteControlCar();
            car.Conducir();
            Assert.Equal("Distancia conducida: 20 metros", car.MostrarDistancia());
        }

        [Fact]
        public void Distance_display_after_driving_multiple_times()
        {
            var car = new RemoteControlCar();

            for (var i = 0; i < 17; i++)
            {
                car.Conducir();
            }

            Assert.Equal("Distancia conducida: 340 metros", car.MostrarDistancia());
        }

        [Fact]
        public void Battery_display_after_driving_once()
        {
            var car = new RemoteControlCar();
            car.Conducir();
            Assert.Equal("Batería al 99%", car.MostrarBateria());
        }

        [Fact]
        public void Battery_display_after_driving_multiple_times()
        {
            var car = new RemoteControlCar();

            for (var i = 0; i < 23; i++)
            {
                car.Conducir();
            }

            Assert.Equal("Batería al 77%", car.MostrarBateria());
        }

        [Fact]
        public void Battery_display_when_battery_empty()
        {
            var car = new RemoteControlCar();

            // Se vacía la batería
            for (var i = 0; i < 100; i++)
            {
                car.Conducir();
            }

            // Intento de conducir nuevamente (no debería funcionar)
            car.Conducir();

            Assert.Equal("Batería vacía", car.MostrarBateria());
        }

        [Fact]
        public void Distance_display_when_battery_empty()
        {
            var car = new RemoteControlCar();

            // Se vacía la batería
            for (var i = 0; i < 100; i++)
            {
                car.Conducir();
            }

            // Intento de conducir nuevamente (no debería funcionar)
            car.Conducir();

            Assert.Equal("Distancia conducida: 2000 metros", car.MostrarDistancia());
        }
    }
}