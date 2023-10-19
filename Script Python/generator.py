from gtts import gTTS
from pydub import AudioSegment


for numero in range(1, 5):  # Genera números del 1 al 99
    mensaje = str(numero)  # Convierte el número en una cadena de texto
    speech = gTTS(mensaje, lang='es', tld='com.mx', slow=False)
    nombre_archivo = f"{numero}.mp3"
    nombre_archivoWav = f"{numero}.wav"
    speech.save(nombre_archivo)
    audio_mp3 = AudioSegment.from_mp3(nombre_archivo)
    audio_wav = audio_mp3.export(nombre_archivoWav, format="wav")