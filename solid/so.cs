public class Cozinheiro
{
	public void fazerPrato(object prato) 
	{
        // TODO: código para a realização de pratos
    }
 
    public double valorDoPrato(object prato) 
	{
        // TODO: código para o calculo do valor do prato
    }
	
    public void recolherPratos() 
	{
        // TODO: código para recolher os pratos
    }
}














public class Cozinheiro
{
	public void fazerPrato(object prato) 
	{
        // código para a realização de pratos
    }
}

public class Caixa
{	
    public double valorDoPrato(object prato) 
	{
        // código para o calculo do valor do prato
    }
}
	
public class Garcon
{	
    public void recolherPratos() 
	{
        // código para recolher os pratos
    }
}






public class Cozinheiro
{
	public void fazerPrato(object prato) 
	{
		if (prato is Omelete)
		{
		// código para a realização de um omelete
		}
		
		if (prato is Macarrao)
		{
		// código para a realização de um macarrao
		}
		
		if (prato is FrangoAssado)
		{
		// código para a realização de um frango assado
		}
  }
}

public class Omelete
{
// propriedades do omelete
}
public class Macarrao
{
// propriedades do macarrão
}
public class FrangoAssado
{
// propriedades do frango assado
}










public class Cozinheiro
{
	public void fazerPrato(Prato prato) 
	{
		prato.Fazer();
  }
}

public abstract class Prato
{
	public abstract void Fazer();
}

public class Omelete : Prato
{
// propriedades do omelete

	public override void Fazer()
	{
	// código para a realização de um omelete
	}
}

public class Churrasco : Prato
{
// propriedades do omelete

	public override void Fazer()
	{
	// código para a realização de um omelete
	}
}

public class Macarrao : Prato
{
// propriedades do macarrao

	public override void Fazer()
	{
	// código para a realização de um macarrao
	}
}

public class FrangoAssado : Prato
{
// propriedades do frango assado

	public override void Fazer()
	{
	// código para a realização de um frango assado
	}
}

public class Churrasco : Prato
{
// propriedades do churrasco

	public override void Fazer()
	{
	// código para a realização de um churrasco
	}
}