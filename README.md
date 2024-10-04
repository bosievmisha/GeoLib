Опишите решение для веб-приложения в kubernetes в виде yaml-манифеста. Оставляйте в коде комментарии по принятым решениям. Есть следующие вводные:

1. У нас kubernetes кластер, в котором пять нод.
2. Приложение испытывает постоянную стабильную нагрузку в течение суток без значительных колебаний. 3 пода справляются с нагрузкой.
3. На первые запросы приложению требуется значительно больше ресурсов CPU, в дальнейшем потребление ровное в районе 0.1 CPU. По памяти всегда “ровно” в районе 128M memory.
4. Приложение требует около 5-10 секунд для инициализации.

Что хотим?

1. Минимальное потребление ресурсов от этого deployment’а.
2. Размещение подов на разных нодах для отказоустойчивости.
3. Чтобы под не обрабатывал запросы до завершения инициализации.
