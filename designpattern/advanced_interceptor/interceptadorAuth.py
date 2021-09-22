from interceptor import Interceptor


class InterceptadorAuth(Interceptor):
    def execute(self, request):
        print("Dentro do Interceptador de Autenticação")
