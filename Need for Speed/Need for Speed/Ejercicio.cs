namespace Need_for_Speed
{
    /*
        Consigna: 
            En este ejercicio organizarás carreras entre varios tipos de coches controlados a distancia. Cada automóvil tiene sus propias características de velocidad y consumo de batería.

            Los coches arrancan con las baterías llenas (100%). Cada vez que conduce el automóvil con el control remoto, cubre la velocidad del automóvil en metros y disminuye el porcentaje de batería restante según el consumo de la batería.

            Si la batería de un automóvil está por debajo de su porcentaje de consumo de batería, ya no podrá conducir el automóvil.

            Cada pista de carreras tiene su propia distancia. Los coches se prueban comprobando si pueden terminar la pista sin quedarse sin batería.

            Tiene seis tareas, cada una de las cuales funcionará con instancias de automóviles con control remoto.

            Tarea 1: Creando un coche teledirigido
                Permita crear un automóvil con control remoto definiendo un constructor para la clase RemoteControlCar que toma la velocidad del automóvil en metros y el porcentaje de consumo de batería como sus dos parámetros (ambos de tipo int).
                    int speed = 5;
                    int batteryDrain = 2;
                    var car = new RemoteControlCar(speed, batteryDrain);

            Tarea 2: Creando una pista de carreras
                Permitir crear una pista de carreras definiendo un constructor para la clase RaceTrack que toma como único parámetro la distancia de la pista en metros (que es de tipo int).
                    int distance = 800;
                    var raceTrack = new RaceTrack(distance);
    
            Tarea 3: Conduce el coche
                mplemente el método RemoteControlCar.Drive() que actualiza la cantidad de metros recorridos en función de la velocidad del automóvil. Implemente también el método RemoteControlCar.DistanceDriven() para devolver la cantidad de metros recorridos por el automóvil.
                    int speed = 5;
                    int batteryDrain = 2;
                    var car = new RemoteControlCar(speed, batteryDrain);
                    car.Drive();

                    car.DistanceDriven();
                    // => 5
                    
            Tarea 4: Compruebe si hay una batería agotada
                Actualice el método RemoteControlCar.Drive() para agotar la batería según el consumo de batería del automóvil. Implemente también el método RemoteControlCar.BatteryDrained() que indica si la batería está agotada.
                    int speed = 5;
                    int batteryDrain = 2;
                    var car = new RemoteControlCar(speed, batteryDrain);
                    car.Drive();

                    car.BatteryDrained();
                    // => false

            Tarea 5: Crea el coche teledirigido Nitro
                El coche de control remoto más vendido es el Nitro, que tiene una impresionante velocidad máxima de 50 metros con un consumo de batería del 4%. Implemente el método (estático) RemoteControlCar.Nitro() para devolver este tipo de automóvil.
                    var car = RemoteControlCar.Nitro();
                    car.Drive();
                    car.DistanceDriven();
                    // => 50

            Tarea 6: Comprueba si un coche teledirigido puede terminar una carrera
                Para terminar una pista de carreras, un automóvil debe poder recorrer la distancia de la pista. Esto significa no agotar su batería antes de haber cruzado la meta. Implemente el método RaceTrack.TryFinishTrack() que toma una instancia RemoteControlCar como parámetro y devuelve true si el automóvil puede terminar la pista de carreras; en caso contrario, devuelve false.
                    int speed = 5;
                    int batteryDrain = 2;
                    var car = new RemoteControlCar(speed, batteryDrain);

                    int distance = 100;
                    var raceTrack = new RaceTrack(distance);

                    raceTrack.TryFinishTrack(car);
                    // => true
    */

    public class RemoteControlCar
    {
        int speed;
        int batteryDrain;
        int battery = 100;

        public RemoteControlCar(int speed, int batteryDrain) 
        {
            this.speed = speed;
            this.batteryDrain = batteryDrain;
        }

        public bool BatteryDrained()
        {
            throw new NotImplementedException("Please implement the RemoteControlCar.BatteryDrained() method");
        }

        public int DistanceDriven()
        {
            return speed;
        }

        public void Drive()
        {
            battery -= batteryDrain;
        }

        public static RemoteControlCar Nitro()
        {
            throw new NotImplementedException("Please implement the (static) RemoteControlCar.Nitro() method");
        }
    }

    public class RaceTrack
    {
        int distance;
        public RaceTrack(int distance)
        {
            this.distance = distance;
        }

        public bool TryFinishTrack(RemoteControlCar car)
        {
            throw new NotImplementedException("Please implement the RaceTrack.TryFinishTrack() method");
        }
    }

}
