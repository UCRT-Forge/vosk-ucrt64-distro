#include <vosk_api.h>
#include <stdio.h>

int main() {
    printf("Vosk API Version: %s\n", vosk_set_log_level(0));
    VoskModel *model = vosk_model_new("model");
    if (!model) {
        printf("Model not found, but API is working!\n");
    }
    vosk_model_free(model);
    return 0;
}
