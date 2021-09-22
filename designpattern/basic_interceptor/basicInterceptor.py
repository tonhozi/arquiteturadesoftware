class BasicInterceptor:
    def __init__(self, application):
        self.application = application

    def execute(self, request):
        print("No interceptor!")
        self.application.execute(request)
