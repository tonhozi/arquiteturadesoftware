abstract class Veiculo
{
  public virtual void LigarMotor();
  public virtual void Acelerar();
}

class Carro : Veiculo
{
  public override void LigarMotor()
  {
    InjetarGasolina();
  }
  public override void InjetarGasolina()
  {
    //TODO: procedimento de ignição
  }
}

class Tesla : Veiculo
{
  public override void LigarMotor()
  {
    AlcancarVoltagem();
  }
  public override void AlcancarVoltagem()
  {
    //TODO: Lógica elétrica
  }
}


class Motorista
{
  public Veiculo Veiculo{get; set;}
  public Motorista(Veiculo veiculo)
  {
    // Veiculo pode receber tanto uma instancia de Tesla ou Carro Combustão
    Veiculo = veiculo;
  }

  public void Dirigir()
  {
    Veiculo.LigarMotor();
    Veiculo.Acelerar();
  }
}



//* Retangulo.cs
namespace LSP_Violacao
{
  class Retangulo
  {
    protected int m_largura;
    protected int m_altura;

    public virtual void setLargura(int largura){
      m_largura = largura;
    }
    public int getLargura(){
      return m_largura;
    }

    public virtual void setAltura(int altura){
      m_altura = altura;
    }
    public int getAltura(){
      return m_altura;
    }
    public int getArea(){
      return m_largura*m_altura;
    }
  }
}

//* Quadrado.cs
namespace LSP_Violacao
{
  class Quadrado : Retangulo
  {
    public override void setLargura(int largura){
      m_largura = largura;
      m_altura = largura;
    }
    public override void setAltura(int altura){
      m_largura = altura;
      m_altura = altura;
    }

  }
}

//* Main.cs
using System;
namespace LSP_Violacao
{
    class Program
    {
        private static Retangulo getNovoRetangulo()
        {
            //um factory
            return new Retangulo();
        }

        static void Main(string[] args)
        {
            //vamos criar um novo retangulo
             Retangulo r = Program.getNovoRetangulo();

            //definindo a largura e altura do retangulo    
             r.setLargura(5);
             r.setAltura(10);
            // o usuário sabe que r é um retângulo
            // e assume que ele pode definir largura e altura
           // como para a classe base(Retangulo)

            Console.WriteLine(r.getArea());
            Console.ReadKey();
           // O valor retornado é 100 e não 50 como era esperado
        }
    }
}



//! return new Retangulo();