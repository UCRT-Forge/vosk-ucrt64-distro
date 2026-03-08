import vosk
import os
import sys

def test_vosk():
    # Укажите здесь путь к вашей распакованной модели
    model_path = 'model' 
    
    if not os.path.exists(model_path):
        print(f'ERROR: Model not found at path: "{os.path.abspath(model_path)}"')
        print('Please download a model and extract it to the "model" folder.')
        sys.exit(1)

    try:
        model = vosk.Model(model_path)
        print('SUCCESS: Vosk model loaded from:', os.path.abspath(model_path))
    except Exception as e:
        print(f'FATAL ERROR: {e}')

if __name__ == '__main__':
    test_vosk()
