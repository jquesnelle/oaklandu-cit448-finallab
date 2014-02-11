from flask import Flask, render_template, request
import hashlib, json
app = Flask(__name__)

def user(name=None, grade=None):
    ret = {}
    ret['name'] = name
    ret['grade'] = grade
    pass_str = hashlib.md5(name).hexdigest()
    ret['user_pass'] = pass_str[:6]
    ret['admin_pass'] = pass_str[len(pass_str)-6:]
    return ret
        
grade_list = []

@app.route('/hello-world')
def hello_world():
    return 'Hello, world!'

@app.route('/')
@app.route('/status')
def status():
    return render_template('status.html', grades=grade_list)

@app.route('/status-full')
def status_full():
    return render_template('status-full.html', grades=grade_list)

@app.route('/user-info', methods=['GET'])
def user_info():
    for entry in grade_list:
        if entry['name'] == request.args['name']:
            return json.dumps(entry)
    return 'Unknown user'

@app.route('/update-grade', methods=['POST'])
def update_grade():
    for entry in grade_list:
        if entry['name'] == request.form['name']:
            entry['grade'] = float(request.form['grade'])
            return 'OK'
    return 'Error'
    
if __name__ == '__main__':
    
    user_file = open('users.txt', 'r')
    for line in user_file:
        grade_list.append(user(line.rstrip(), 2.0))
    user_file.close()
    
    app.debug = True
    app.run()