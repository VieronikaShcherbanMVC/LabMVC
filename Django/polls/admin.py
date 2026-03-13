from django.contrib import admin
from .models import Choice, Question

# Inline для Choice
class ChoiceInline(admin.TabularInline):  # компактний вигляд у таблиці
    model = Choice
    extra = 3  # за замовчуванням три порожніх поля для додавання

# Адмінка для Question
class QuestionAdmin(admin.ModelAdmin):
    fieldsets = [
        (None, {"fields": ["question_text"]}),
        ("Date information", {"fields": ["pub_date"], "classes": ["collapse"]}),
    ]
    inlines = [ChoiceInline]  # додаємо Choice як inline
    list_display = ["question_text", "pub_date", "was_published_recently"]
    list_filter = ["pub_date"]  # фільтр збоку
    search_fields = ["question_text"]  # поле пошуку

# Реєстрація Question з кастомним QuestionAdmin
admin.site.register(Question, QuestionAdmin)