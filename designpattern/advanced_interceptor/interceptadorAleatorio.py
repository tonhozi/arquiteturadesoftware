from interceptor import Interceptor


class InterceptadorAleatorio(Interceptor):
    def execute(self, request):
        print("Dentro do Interceptador Aleatorio")
