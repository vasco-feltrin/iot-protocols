# iotprotocols
Client: Vasco
Server: Riccardo


# Client 
Il client consiste in una semplice console App in .NET 8

# Server
Il server consiste in un applicazione ASP.NET

# Implementazione

IProtocolInterface è l'interfaccia per l'invio dei messaggi attraverso il metodo Send().
E' implementata per HTTP, MQTP e AMQP.

La cartella 'Models' è condivisa da entrambi i progetti, client e server. 
Contiene classi per la serializzazione e deserializzazione dei dati dei sensori.

# Sensori
'CarModel' è un contentitore per i dati di tutti i sensori della macchina. Questi includono:
- Gps: sensore che trasmette longitudine, latitudine e altitudine
- Temperatura: trasmette la temperatura
- Giroscopio: trasmette dati riguardo alla rotazione e accelerazione del veicolo. Questo tipo di 
dati possono essere critici nel caso di verifichi un incidente per determinare il corso degli eventi.