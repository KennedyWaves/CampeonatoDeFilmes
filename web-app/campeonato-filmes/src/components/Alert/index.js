import Button from '@mui/material/Button';
import Dialog from '@mui/material/Dialog';
import DialogActions from '@mui/material/DialogActions';
import DialogContent from '@mui/material/DialogContent';
import DialogContentText from '@mui/material/DialogContentText';
import DialogTitle from '@mui/material/DialogTitle';

export default function AlertDialog(props) { 
    return (
      <div>
        <Dialog
          open={props.open}
          aria-labelledby="alert-dialog-title"
          aria-describedby="alert-dialog-description"
        >
          <DialogTitle id="alert-dialog-title">
          {props.titulo}
          </DialogTitle>
          <DialogContent>
            <DialogContentText id="alert-dialog-description">
              {props.texto}
            </DialogContentText>
          </DialogContent>
          <DialogActions>
            <Button onClick={()=>{props.fechaDialogo({open:false})}}>Fechar</Button>
          </DialogActions>
        </Dialog>
      </div>
    );
  }
  