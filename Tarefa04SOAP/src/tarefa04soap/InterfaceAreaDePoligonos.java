package tarefa04soap;

import javax.jws.WebMethod;
import javax.jws.WebService;
import javax.jws.soap.SOAPBinding;
import javax.jws.soap.SOAPBinding.Style;

@WebService
@SOAPBinding(style = Style.RPC)
public interface InterfaceAreaDePoligonos {
    // Polígonos regulares
    @WebMethod double areaTriangulo(double base, double altura);
    @WebMethod double areaRetangulo(double base, double altura);
    @WebMethod double areaPentagono(double lado, double apotema);
    @WebMethod double areaHexagono(double lado);
    
    // Polígonos irregulares
    @WebMethod double areaLosango(double diagonalMaior, double diagonalMenor);
    @WebMethod double areaTrapezio(double baseMaior, double baseMenor, double altura);
}
