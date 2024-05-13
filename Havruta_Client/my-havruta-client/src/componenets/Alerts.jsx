import InfoIcon from '@mui/icons-material/Info';
import WarningIcon from '@mui/icons-material/Warning';
import ReportIcon from '@mui/icons-material/Report';
import CheckCircleIcon from '@mui/icons-material/CheckCircle';
import CloseRoundedIcon from '@mui/icons-material/CloseRounded';
import * as React from 'react';
import Box from '@mui/joy/Box';
import Alert from '@mui/joy/Alert';
import IconButton from '@mui/joy/IconButton';
import Typography from '@mui/joy/Typography';

export default function Alerts({type, text}) {
    // type: true -> success, false -> error
  const items = [
    { title: 'Success', color: 'success', icon: <CheckCircleIcon /> },
    { title: 'Warning', color: 'warning', icon: <WarningIcon /> },
    { title: 'Error', color: 'danger', icon: <ReportIcon /> },
    { title: 'Neutral', color: 'neutral', icon: <InfoIcon /> },
  ];

  const alertTypes = {
    "true":{ title: 'Success', color: 'success', icon: <CheckCircleIcon /> },
    "false":{ title: 'Error', color: 'danger', icon: <ReportIcon /> },
  }
  
  return (
    <Box sx={{ display: 'flex', gap: 2, width: '100%', flexDirection: 'column' }}>

    <Alert
          key={alertTypes[type + ''].title}
          sx={{ alignItems: 'flex-start' }}
          startDecorator={alertTypes[type + ''].icon}
          variant="soft"
          color={alertTypes[type + ''].color}
          endDecorator={
            <IconButton variant="soft" color={alertTypes[type + ''].color}>
              <CloseRoundedIcon />
            </IconButton>
          }
        >
          <div>
            <div>{alertTypes[type + ''].title}</div>
            <Typography level="body-sm" color={alertTypes[type + ''].color}>
              {text}
            </Typography>
          </div>
        </Alert>
    </Box>
  );
}