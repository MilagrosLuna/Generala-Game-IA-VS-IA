<h1 align="center"><img src="https://ichef.bbci.co.uk/news/640/cpsprodpb/12140/production/_92484047_thinkstockphotos-502872172.jpg"/></p> 



Generala
Realizada por Milagros Luna
## La solucion se encuentra en la carpeta Entidades_2TpParcialLabo 

  
</div>


## Acerca del Proyecto

Este proyecto me enseño muchas cosas, y tambien me permitio volcar mi conocimiento. Me enseño a jugar a la generala aunque simplifique algunas reglas(detalladas abajo), queria poder llegar a desarollar una partida entre Jugadores pero no pude con el tiempo asi que preferi reforzar lo que tenia. 
Al ejecutar el programa por primera vez, te saldra que no hay jugadores en los archivos, despues de simular partidas podras ver los jugadores.

Detallo las reglas que sigue el juego:
* 11 rondas, pero se puede cancelar una partida, hacer que termine antes
* En vez de realizar 3 tiradas, solo tiene una tirada (al poner esto decidi sacar el hecho de que una jugada sea servida)
* VALORES: Escalera: 20, Full: 30, Poker: 40, Generala: 50 y Doble Generala: 100.
* Se juega con 5 dados
* Escalera: 1-2-3-4 y 5 ; 2-3-4-5 y 6 ó 3-4-5-6 y 1, el 1 se puede colocar después del 6 y volver a empezar, mientras todos sean distintos se puede formar escalera
* Full: 3 dados del mismo número y 2 iguales de otro.
* Poker: 4 dados iguales
* Generala: 5 dados iguales.


## Tabla de contenidos:
---
- [Interfaces y Generics](#Interfaces-y-Generics)
- [Serialización](#Serialización)
- [Escritura de archivos](#Escritura-de-archivos)
- [Manejo de excepciones](#Manejo-de-excepciones)
- [SQL](#SQL)
- [Unit Testing](#Unit-Testing)
- [Delegados](#Delegados)
- [Task](#Task)
- [Eventos](#Eventos)
- [Diagrama de clases](#Diagrama-de-clases)

## Interfaces y Generics
---
Utilizo interfaces con generics para poder tener serializadores que me permitan manejar distintas tipos de objetos.
La interfaz en si obliga a los serializadores(xml y json) a desarollar el metodo para serializar y para deserializar, ya que ambos 
tienen distinta manera de hacerlo.

```bash
public interface ISerializador<T> where T : class , new()
{
    public bool Serializar(T obj);
    public T Deserializar();
}

public class SerializadorXml<T> : ISerializador<T> where T : class, new()

public class SerializadorJson<T> : ISerializador<T> where T : class, new()

private SerializadorJson<List<Jugador>> serializadorJson = new SerializadorJson<List<Jugador>>("Jugadores.json");
private SerializadorXml<List<Jugador>> serializadorXml = new SerializadorXml<List<Jugador>>("Jugadores.xml");
```
 
## Serialización
---
Utilice Json y Xml.
En Json guarde los datos de los jugadores con una puntuacion mayor a 100pts y en Xml guarde los de puntuacion menor a 101pts.

## Escritura de archivos
---
En la escritura de archivos guarde los datos de los jugadores que se llamen maxi. 
En las partidas siimuladas se toman nombres de un array para la ia de manera aleatoria y cada vez que la ia se llame maxi se 
guarda la informacion, cuantos puntos obtuvo y la cantidad de rondas que jugo.

## Manejo de excepciones
---
Donde mas utilize es en la clase Acceso de datos, la cual se encarga de trabajar con la base de datos y en cada cosa que hago manejo cualquier exepcion 
que se pueda producir.

```bash
ejemplo:
  public bool ProbarConexion()
  {
      bool rta = true;
      try
      {
          this.conexion.Open();
      }
      catch (Exception)
      {
          rta = false;
      }
      finally
      {
          if (this.conexion.State == ConnectionState.Open)
          {
              this.conexion.Close();
          }
      }
      return rta;
  }
```

## SQL
---
En la base de datos guardo las partidas jugadas para luego poder acceder a un historial de estas y tambien tengo la posibilidad de modificar los datos de 
alguna partida y/o eliminarlos.

## Unit Testing
---
Lo utilice para testear codigo que podria llegar a generar problemas.

## Delegados
---
Utilize delegados para que el jugador pueda acceder a la funcion tirada que es de un form, la cual actualiza las imagenes de los dados en base al
metodo lanzar de los dados y me devuelve los dados jugados.
Lo hice de esta manera ya que la tirada se hace en cada turno y la lñogica del jugar turno no le pertenece a un form
sino que le pertenece a un jugador y queria que las imagenes se actualizen por cada turno.
Tambien hay delegados en los eventos que se llaman en la task de jugar partida

## Task
---
Utilize tasks para las partidas, cada partida que se crea es una task y esto es para que se ejecute en segundo plano automáticamente 
y el flujo de ejecución del programa no se bloqueé.

## Eventos
---
Al jugar una partida que se hace en una task el form no permite cambia los datos de algun control en un subproceso por eso genero un evento para
que pueda modifcar los datos en el hilo principal
```bash
ejemplo :
  private void ActualizarLbl(string nombre,int rondas)
  {
      if (InvokeRequired)
      {
          Action<string,int> actualizar = ActualizarLbl;
          object[] obj = new object[] { nombre,rondas };

          BeginInvoke(actualizar,obj);
      }
      else
      {
          this.label_turnoJugador.Text = nombre;
          this.label_rondas.Text = "Ronda n°" + rondas;
      }
  }
```
## Diagrama de clases
---
<p align="center"><img src="https://cdn.discordapp.com/attachments/1035311212088545381/1040704815694618705/image.png"/></p> 
