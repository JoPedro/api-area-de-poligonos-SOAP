package tarefa04soap;

import javax.xml.ws.Endpoint;

public class PublisherAreaDePoligonos {
    public static void main(String[] args) {
        Endpoint.publish("http://localhost:9876/areapoligonos", new ServicoAreaDePoligonos());
    }
}
