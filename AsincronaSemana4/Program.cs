
using AsincronaSemana4.entidades;
using AsincronaSemana4.negocio;

EntidadDeConteo Texto = new EntidadDeConteo ();
ClsNegocioDeConteo clsNegocioDeConteo = new ClsNegocioDeConteo();


  Console.WriteLine("Por favor ingrese un Texto:");
  string textoIngresado = Console.ReadLine();

  EntidadDeConteo entidad = new EntidadDeConteo();
  entidad.Texto = textoIngresado;

  ClsNegocioDeConteo negocio = new ClsNegocioDeConteo();
  int cantidadDeLetras = negocio.ContarLetras(entidad);

  Console.WriteLine ("La cantidad de letras que usted ingreso son: " + cantidadDeLetras);