from interceptorManager import InterceptorManager
from interceptadorLog import InterceptadorLog
from interceptadorAuth import InterceptadorAuth
from interceptadorAleatorio import InterceptadorAleatorio
from application import Application

interceptorManager = InterceptorManager(Application())
interceptadorLog = InterceptadorLog()
interceptadorAuth = InterceptadorAuth()
interceptadorAleatorio = InterceptadorAleatorio()

interceptorManager.add(interceptadorLog)
interceptorManager.add(interceptadorAuth)
interceptorManager.execute("Requisição")

interceptorManager.remove(interceptadorAuth)
interceptorManager.add(interceptadorAleatorio)
interceptorManager.execute("Requisição")
