from interceptor import Interceptor


class InterceptadorLog(Interceptor):
    def execute(self, request):
        print("Dentro do Interceptador de Logs")
