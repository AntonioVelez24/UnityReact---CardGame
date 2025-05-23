mergeInto(LibraryManager.library, {
  SendMessageToReact: function (ptr) {
    var message = UTF8ToString(ptr);
    console.log("Mensaje desde Unity:", message);

    // Enviar a React si está dentro de un iframe
    if (window.parent) {
      window.parent.postMessage({ unityData: message }, "*");
    }
  }
});
