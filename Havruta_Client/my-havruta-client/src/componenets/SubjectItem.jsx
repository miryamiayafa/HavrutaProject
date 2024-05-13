import { useEffect, useState } from 'react';
import Checkbox from '@mui/joy/Checkbox';
import List from '@mui/joy/List';
import ListItem from '@mui/joy/ListItem';
import Typography from '@mui/joy/Typography';
import Radio from '@mui/joy/Radio';
import RadioGroup from '@mui/joy/RadioGroup';
import Box from '@mui/joy/Box';
import Input from '@mui/joy/Input'
import StudyTime from './StudyTime';
import Sheet from '@mui/joy/Sheet';
import { alpha } from '@mui/material';
import ModeToggle from './ButtonChangeMode';


function SubjectItem() {
  const [checkboxStates, setCheckboxStates] = useState({});

  useEffect(() => {
    // No need for event listener, state change will handle visibility
  }, []);

  const handleCheckboxChange = (id) => {
    setCheckboxStates((prevStates) => ({
      ...prevStates,
      [id]: !prevStates[id], // Toggle the visibility state of the checkbox with the given ID
    }));
  };

  return ( 
    <div style={{ textAlign: 'center' }}>
      <Typography variant="h4" mb={2} sx={{color : '#12467B',}}>
      <StudyTime />
        <h1>איזה כיף שהצטרפת אלינו</h1>
       </Typography>
       <div style={{display: 'flex', justifyContent: 'flex-start'}}>
        <Typography variant="h6" style={{ order: 1 }} mb={2} sx={{
         width: 300,
         mx: 'auto', // margin left & right
         my: 4, // margin top & bottom
         py: 3, // padding top & bottom
         px: 2, // padding left & right
         display: 'flex',
         flexDirection: 'column',
         gap: 2,
         borderRadius: 'sm',
         boxShadow: 'md',
         color : '#0B6BCB',

        // py: 2,
        // display: 'grid ',
        // gap: 2,
        // alignItems: 'center',
        // flexWrap: 'wrap',
        // marginLeft: '40%',
        // marginRight: '7%',
        // marginTop: '3%',

      }}>
        <h2 >אנא מלא את פרטיך</h2>
     <Box
     

    >
      <label>Enter First Name</label>  
      <Input placeholder="Type first name" variant="outlined" color="primary" />
      <label>Enter Last Name</label>
      <Input placeholder="Type last name " variant="outlined" color="neutral" />
      <label>Enter Phone Number</label>
      <Input placeholder="Type Phone Number" variant="outlined" color="danger" />
      <Input placeholder="Type in here…" variant="outlined" color="success" />
      <Input placeholder="Type in here…" variant="outlined" color="warning" />
     </Box>
     </Typography>

      < Typography variant="h6" level="body-sm" style={{ order: -1 }} mb={2} sx={{
       width: 300,
       mx: 'auto', // margin left & right
       my: 4, // margin top & bottom
       py: 3, // padding top & bottom
       px: 2, // padding left & right
       display: 'flex',
       flexDirection: 'column',
       gap: 2,
       borderRadius: 'sm',
       boxShadow: 'md',
       color : '#0B6BCB',
      //  py: 2,
      //  display: 'grid ',
      //  gap: 2,
      //  alignItems: 'center',
      //  flexWrap: 'wrap',
      //  marginLeft: '7%',
      //  marginTop: '0%',
  
       
      }}
       >
        <h2>בחר אילו נושאים ברצונך ללמוד</h2>
       
      <List size="sm">
        <ListItem>
          <Checkbox
            label="הלכה"
            id="revealCheckbox1"
            checked={checkboxStates['revealCheckbox1']}
            onChange={() => handleCheckboxChange('revealCheckbox1')}
          />
          {checkboxStates['revealCheckbox1'] && (
            <div id="hiddenContent1">
              <RadioGroup defaultValue="outlined" name="radio-buttons-group">
                <Radio value="קשה" label="קשה" variant="outlined" />
                <Radio value="בינוני" label="בינוני" variant="outlined" />
                <Radio value="קל" label="קל" variant="outlined" />
              </RadioGroup>
            </div>
          )}
        </ListItem>
        <ListItem>
          <Checkbox
            label="מוסר"
            id="revealCheckbox2"
            checked={checkboxStates['revealCheckbox2']}
            onChange={() => handleCheckboxChange('revealCheckbox2')}
          />
          {checkboxStates['revealCheckbox2'] && (
            <div id="hiddenContent2">
              <RadioGroup defaultValue="outlined" name="radio-buttons-group">
                <Radio value="קשה" label="קשה" variant="outlined" />
                <Radio value="בינוני" label="בינוני" variant="outlined" />
                <Radio value="קל" label="קל" variant="outlined" />
              </RadioGroup>
            </div>
          )}
        </ListItem>
        <ListItem>
          <Checkbox
            label="השקפה"
            id="revealCheckbox3"
            checked={checkboxStates['revealCheckbox3']}
            onChange={() => handleCheckboxChange('revealCheckbox3')}
          />
          {checkboxStates['revealCheckbox3'] && (
            <div id="hiddenContent3">
              <RadioGroup defaultValue="outlined" name="radio-buttons-group">
                <Radio value="קשה" label="קשה" variant="outlined" />
                <Radio value="בינוני" label="בינוני" variant="outlined" />
                <Radio value="קל" label="קל" variant="outlined" />
              </RadioGroup>
            </div>
          )}
        </ListItem>
        <ListItem>
          <Checkbox
            label="שמירת הלשון"
            id="revealCheckbox4"
            checked={checkboxStates['revealCheckbox4']}
            onChange={() => handleCheckboxChange('revealCheckbox4')}
          />
          {checkboxStates['revealCheckbox4'] && (
            <div id="hiddenContent4">
              <RadioGroup defaultValue="outlined" name="radio-buttons-group">
                <Radio value="קשה" label="קשה" variant="outlined" />
                <Radio value="בינוני" label="בינוני" variant="outlined" />
                <Radio value="קל" label="קל" variant="outlined" />
              </RadioGroup>
            </div>
          )}
        </ListItem>
        <ListItem>
          <Checkbox
            label="גמרא"
            id="revealCheckbox5"
            checked={checkboxStates['revealCheckbox5']}
            onChange={() => handleCheckboxChange('revealCheckbox5')}
          />
          {checkboxStates['revealCheckbox5'] && (
            <div id="hiddenContent5">
              <RadioGroup defaultValue="outlined" name="radio-buttons-group">
                <Radio value="קשה" label="קשה" variant="outlined" />
                <Radio value="בינוני" label="בינוני" variant="outlined" />
                <Radio value="קל" label="קל" variant="outlined" />
              </RadioGroup>
            </div>
          )}
        </ListItem>
      </List>
      </Typography>
      </div>
    </div>
  );
}

export default SubjectItem;
