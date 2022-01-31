package tarefa04soap;

import javax.jws.WebService;

@WebService(endpointInterface = "tarefa04soap.InterfaceAreaDePoligonos")
public class ServicoAreaDePoligonos implements InterfaceAreaDePoligonos {

    @Override
    public double areaTriangulo(double base, double altura) {
        System.out.println("Área de Triângulo");
        return (base * altura) / 2;
    }

    @Override
    public double areaRetangulo(double base, double altura) {
        System.out.println("Área de Retângulo");
        return base * altura;
    }

    @Override
    public double areaPentagono(double lado, double apotema) {
        System.out.println("Área de Pentágono");
        return 5 * lado * apotema;
    }
    
    @Override
    public double areaHexagono(double lado) {
        System.out.println("Área de Hexágono");
        return (3 * Math.pow(lado, 2) * Math.sqrt(3)) / 2;
    }

    @Override
    public double areaLosango(double diagonalMaior, double diagonalMenor) {
        System.out.println("Área de Losango");
        return (diagonalMaior * diagonalMenor) / 2;
    }

    @Override
    public double areaTrapezio(double baseMaior, double baseMenor, double altura) {
        System.out.println("Área de Trapézio");
        return ((baseMaior + baseMenor) * altura) / 2;
    }
    
}
