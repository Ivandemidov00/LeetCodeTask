#!/bin/bash
set -e

echo "📄 Генерация README.md из проектов *_Solution.csproj"

# Находим все проекты, соответствующие шаблону
projects=$(find . -type f -name '*_Solution.csproj' | sort)

# Начало README
{
  echo "# LeetCode Solutions"
  echo ""
  echo "Автогенерируемый список решённых задач по проектам с суффиксом *_Solution.csproj"
  echo ""
  echo "## Решённые задачи"
  echo ""
} > README.md

# Добавляем каждое имя задачи
while IFS= read -r path; do
  filename=$(basename "$path")
  taskname="${filename%_Solution.csproj}"

  # Удаляем префиксы LeetCode. если есть
  taskname="${taskname#LeetCode.}"

  # Вставим тире перед числом
  name=$(echo "$taskname" | sed -E 's/(.*)_([0-9]+)/\1 (\2)/')

  echo "- $name" >> README.md
done <<< "$projects"
