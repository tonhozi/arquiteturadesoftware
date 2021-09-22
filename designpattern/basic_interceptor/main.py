from basicInterceptor import BasicInterceptor
from application import Application

basicInterceptor = BasicInterceptor(Application())
basicInterceptor.execute("Requisição")
