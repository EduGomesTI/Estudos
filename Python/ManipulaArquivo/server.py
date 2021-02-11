from jedi.plugins.flask import flask

app = flask("Meu primeiro app")

@app.route("/")
def index():
    return "<1>Hello Flask!</>"

app.run()

