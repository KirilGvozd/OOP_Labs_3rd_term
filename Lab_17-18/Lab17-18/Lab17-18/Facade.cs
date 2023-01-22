using System;

namespace Lab17_18
{
    class TextEditor
    {
        public TextEditor() => Console.WriteLine("Студент поступил на программиста");

        public void CreateCode() => Console.WriteLine("Пишет код");
        public void SaveAndCommit() => Console.WriteLine("Сохраняет проект и коммитит в репозиторий.");
    }
    class Compiller
    {
        public void Compile() => Console.WriteLine("Компиляция приложения");
    }
    class Clr
    {
        public void ExecutionOfApplication() => Console.WriteLine("Выполнение приложения");
        public void Finish() => Console.WriteLine("Завершение работы приложения");
    }

    class VisualStudioFacade
    {
        private readonly TextEditor _textEditor;
        private readonly Compiller _compiler;
        private readonly Clr _clr;
        public VisualStudioFacade(TextEditor textEditor, Compiller compiler, Clr clr)
        {
            this._textEditor = textEditor;
            this._compiler = compiler;
            this._clr = clr;
        }
        public void Start()
        {
            _textEditor.CreateCode();
            _textEditor.SaveAndCommit();
            _compiler.Compile();
            _clr.ExecutionOfApplication();
        }
        public void Stop() => _clr.Finish();
    }

    class Programmer
    {
        public void CreateApplication(VisualStudioFacade facade)
        {
            facade.Start();
            facade.Stop();
        }
    }
}
